using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class AndOperationNode : LogicalOperationNode
    {
        #region	Builder Methods

        public AndOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var falseLabel = gen.DefineLabel();
            var endLabel = gen.DefineLabel();

            LeftOperand.GenCode(cg);
            gen.Emit(OpCodes.Brfalse, falseLabel);

            RightOperand.GenCode(cg);
            gen.Emit(OpCodes.Brfalse, falseLabel);

            gen.Emit(OpCodes.Ldc_I4_1);
            gen.Emit(OpCodes.Br, endLabel);

            gen.MarkLabel(falseLabel);
            gen.Emit(OpCodes.Ldc_I4_0);

            gen.MarkLabel(endLabel);
        }

        #endregion
    }
}
