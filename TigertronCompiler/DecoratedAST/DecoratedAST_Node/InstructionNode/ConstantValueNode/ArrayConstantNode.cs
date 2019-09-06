using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class ArrayConstantNode : ConstantValueNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        public InstructionNode LengthExpr { get { return GetChild(1) as InstructionNode; } }
        public InstructionNode InitValueExpr { get { return GetChild(2) as InstructionNode; } }
        private string _baseTypeId;
        private string ArrayTypeId { get { return _baseTypeId ?? (_baseTypeId = GetChild(0).Text); } }

        #endregion

        #region	Builder Methods

        public ArrayConstantNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            TypeExpression BaseType = null;

            //Check ArrayType
            TypeSymbol type;
            if (MappingDeclaration(ArrayTypeId, symbolTable, errors, Line, CharPositionInLine, out type))
            {
                if (!(type.TypeExpression.PrimitiveType is ArrayType))
                {
                    string message = string.Format("{0} type cannot be converted to an array type", type.TypeExpression);
                    errors.Add(new Error(message, Line, CharPositionInLine));
                }
                else
                    BaseType = (type.TypeExpression.PrimitiveType as ArrayType).BaseType;
            }

            //Check LengthExpr
            if (LengthExpr.CheckSemantic(errors, symbolTable))
                if (!(LengthExpr.ReturnType.PrimitiveType is IntegerType))
                    errors.Add(new Error("The type of length expression must be int", Line, CharPositionInLine));

            //Check InitValueExpr
            string decoratedErr = string.Format("The type of init value expression is not equivalent with the subyacent type of '{0}'", ArrayTypeId);
            if (InitValueExpr.CheckSemantic(errors, symbolTable))
                if (BaseType != null)
                    CheckAssigment(InitValueExpr, BaseType, errors, decoratedErr);

            Scope = symbolTable.TopScope.Clone();
            ReturnType = (initErr == errors.Count) ? type.TypeExpression : TypeExpression.ErrorType;
            return (initErr == errors.Count);
        }

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var length = gen.DeclareLocal(typeof(int));
            var arrayRef = gen.DeclareLocal(ReturnType.ILType);

            //Creamos un array del tipo del elemento con el que lo van a llenar
            LengthExpr.GenCode(cg);
            gen.Emit(OpCodes.Dup);
            gen.Emit(OpCodes.Stloc, length);
            ArrayType arrayType = (ReturnType.PrimitiveType as ArrayType);
            gen.Emit(OpCodes.Newarr, arrayType.BaseType.ILType);
            gen.Emit(OpCodes.Stloc, arrayRef);

            //Labels para el ciclo For
            var startForLabel = gen.DefineLabel();
            var endForLabel = gen.DefineLabel();

            //Declaramos el indice del For y lo inicializamos en 0
            var index = gen.DeclareLocal(typeof(int));
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Stloc, index);

            gen.MarkLabel(startForLabel);//Comenzamos el Ciclo

            //Comprobamos que se cumpla la condicion del ciclo
            gen.Emit(OpCodes.Ldloc, length);
            gen.Emit(OpCodes.Ldloc, index);
            gen.Emit(OpCodes.Beq, endForLabel);

            //Ponemos el elemento dado en la posicion del array
            gen.Emit(OpCodes.Ldloc, arrayRef);
            gen.Emit(OpCodes.Ldloc, index);

            InitValueExpr.GenCode(cg);
            gen.Emit(OpCodes.Stelem, arrayType.BaseType.ILType);

            //Aumentamos en 1 a index
            gen.Emit(OpCodes.Ldloc, index);
            gen.Emit(OpCodes.Ldc_I4_1);
            gen.Emit(OpCodes.Add);
            gen.Emit(OpCodes.Stloc, index);

            //Volvemos al inicio del ciclo
            gen.Emit(OpCodes.Br, startForLabel);

            //Fin del ciclo
            gen.MarkLabel(endForLabel);
            gen.Emit(OpCodes.Ldloc, arrayRef);//Ponemos en la pila la referencia al objeto array
        }

        #endregion
    }
}
