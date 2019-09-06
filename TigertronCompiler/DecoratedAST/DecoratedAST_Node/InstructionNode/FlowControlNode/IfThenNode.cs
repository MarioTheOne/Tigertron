using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class IfThenNode : ConditionalJumpNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        #endregion

        #region	Builder Methods

        public IfThenNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var endLabel = gen.DefineLabel();
            ConditionExp.GenCode(cg);
            gen.Emit(OpCodes.Brfalse, endLabel);
            ThenInstruction.GenCode(cg);
            gen.MarkLabel(endLabel);
        }

        #endregion

        #region	Auxiliar Semantic

        protected override TypeExpression ExpectedType()
        {
            TypeMessage = "The second expression of IfThen instruction must be a valueless expression";
            return TypeExpression.VoidType;
        }

        #endregion
    }
}
