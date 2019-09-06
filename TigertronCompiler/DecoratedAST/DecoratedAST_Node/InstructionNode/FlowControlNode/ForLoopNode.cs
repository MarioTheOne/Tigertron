using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class ForLoopNode : LoopsNode
    {
        #region	Fields and Properties

        private string _iterationVar;
        public string IterationVar
        {
            get { return _iterationVar ?? (_iterationVar = (GetChild(1).Text)); }
        }

        private InstructionNode _initValue;
        public InstructionNode InitValue
        {
            get { return _initValue ?? (_initValue = (GetChild(2) as InstructionNode)); }
        }

        #endregion

        #region	Builder Methods

        public ForLoopNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            //Creamos los campos y asignamos los fieldBuilder a los simbolos
            var gen = cg.GetGenerator;
            var iterVar = cg.TypeBuilder.DefineField(IterationVar + "_" + Scope.Id, typeof(int), FieldAttributes.Static | FieldAttributes.Public);
            IterationInstr.Scope.MappingDeclaration<FieldSymbol>(IterationVar).FieldBuilder = iterVar;

            //Inicializamos la variable de iteracion
            InitValue.GenCode(cg);
            gen.Emit(OpCodes.Stsfld, iterVar);

            //Creamos una variable local y le asignamos el valor de la cota superior para usarlo en las repetidas iteraciones
            var upperBound = gen.DeclareLocal(typeof(int));
            ConditionExp.GenCode(cg);
            gen.Emit(OpCodes.Stloc, upperBound);

            //Creamos los labels de inicio y fin del ciclo
            var startLoopLabel = gen.DefineLabel();
            var endLoopLabel = gen.DefineLabel();

            //Ponemos la etiqueta del final en la pila por si hay un break dentro del ciclo
            cg.LoopsEndLabels.Push(endLoopLabel);

            //Comprobamos la condicion del ciclo
            gen.MarkLabel(startLoopLabel);
            gen.Emit(OpCodes.Ldsfld, iterVar);
            gen.Emit(OpCodes.Ldloc, upperBound);
            gen.Emit(OpCodes.Bgt, endLoopLabel);

            //Generamos el cuerpo del For
            IterationInstr.GenCode(cg);
            

            //Aumentamos en 1 la variable de iteracion
            gen.Emit(OpCodes.Ldsfld, iterVar);
            gen.Emit(OpCodes.Ldc_I4_1);
            gen.Emit(OpCodes.Add);
            gen.Emit(OpCodes.Stsfld, iterVar);

            //Saltamos al chequeo de la condicion nuevamente
            gen.Emit(OpCodes.Br, startLoopLabel);

            //Se termina el ciclo y se quita la etiqueta de la pila
            gen.MarkLabel(endLoopLabel);
            cg.LoopsEndLabels.Pop();
        }

        #endregion

        #region	Auxiliar Semantic
        
        protected override bool CheckCondition(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            //check IterationVar
            //verifico si puedo usar una variable con el nombre de IterationVar(no puede sobreescribir a ninguna variable de iteracion)
            if (symbolTable.IsThereIterationVar(IterationVar))
                errors.Add(new Error("Iteration var of a for loop cannot be hidden", InitValue.Line, InitValue.CharPositionInLine));
            if (symbolTable.GetUniverseDeclaration<StatementSymbol>(IterationVar) != null)
                errors.Add(new Error("Function's names of standard library could not be used in declarations", Line, CharPositionInLine));
            //Check upper value
            base.CheckCondition(errors, symbolTable);
            //Check lower value)
            if (InitValue.CheckSemantic(errors,symbolTable))
            {
                //verifico que InitValue sea del tipo int
                if (!(InitValue.ReturnType.PrimitiveType is IntegerType))
                    errors.Add(new Error("Expression  cannot be converted to 'int' type", InitValue.Line, InitValue.CharPositionInLine));

                //creo un nuevo scope donde se añadira la variable de iteracion
                symbolTable.OpenScope(ScopeType.Loop);//Note: no hay conflictos locales pues esto es lo unico que hay en el scope
                symbolTable.InsertDeclaration(new FieldSymbol(IterationVar, TypeExpression.IntType, true));
            }
            if (initErr == errors.Count) return true;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}
