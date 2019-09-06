using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class NilValueNode : SimpleConstantNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        #endregion

        #region	Builder Methods

        public NilValueNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            Scope = symbolTable.TopScope.Clone();
            ReturnType = TypeExpression.NilType;
            return true;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            cg.GetGenerator.Emit(OpCodes.Ldnull);
        }

        #endregion
    }
}
