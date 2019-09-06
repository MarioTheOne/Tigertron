using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class WhileLoopNode : LoopsNode
    {
        #region	Fields and Properties

        #endregion

        #region	Builder Methods

        public WhileLoopNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var endLabel = gen.DefineLabel();
            var loopLabel = gen.DefineLabel();

            //ponemos en la pila la etiqueta de fin de ciclo por si necesitamos hacer break dentro del ciclo saber donde saltar
            cg.LoopsEndLabels.Push(endLabel);
            gen.MarkLabel(loopLabel);//Inicio del ciclo
            ConditionExp.GenCode(cg);
            gen.Emit(OpCodes.Brfalse, endLabel);//Si la condicion es false terminamos el ciclo

            IterationInstr.GenCode(cg);

            gen.Emit(OpCodes.Br, loopLabel);
            gen.MarkLabel(endLabel);
            cg.LoopsEndLabels.Pop();//Retiramos la etiqueta de la pila 
        }

        #endregion

        #region	Auxiliar Semantic

        protected override bool CheckCondition(List<Error> errors, SymbolTable symbolTable)
        {
            bool cond = base.CheckCondition(errors, symbolTable);
            symbolTable.OpenScope(ScopeType.Loop);
            return cond;
        }

        #endregion
    }
}
