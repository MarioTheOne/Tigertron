using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public interface IAssignable
    {
        bool IsLValue { get; }

        void AssignValue(ICodeGenerator cg);
    }
}
