using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class OrOperationNode : LogicalOperationNode
    {
        #region	Builder Methods

        public OrOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var trueLabel = gen.DefineLabel();
            var endLabel = gen.DefineLabel();
            //Si leftOperand es true saltar a trueLabel
            LeftOperand.GenCode(cg);
            gen.Emit(OpCodes.Brtrue, trueLabel);
            //Si el segundo lo es idem
            RightOperand.GenCode(cg);
            gen.Emit(OpCodes.Brtrue, trueLabel);
            //Si ninguno es true ponemos 0 en la pila y saltamos al final
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Br, endLabel);
            //Si alguno es true ponemos uno en la pila y seguimos hasta el final
            gen.MarkLabel(trueLabel);
            gen.Emit(OpCodes.Ldc_I4_1);
            //Fin del codigo
            gen.MarkLabel(endLabel);
        }

        #endregion
    }
}
