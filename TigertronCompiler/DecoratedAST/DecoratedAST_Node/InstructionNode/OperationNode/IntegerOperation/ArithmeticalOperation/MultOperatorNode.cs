﻿using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class MultOperationNode : ArithmeticalOperationNode
    {
        #region	Builder Methods

        public MultOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            LeftOperand.GenCode(cg);
            RightOperand.GenCode(cg);
            gen.Emit(OpCodes.Mul);
        }

        #endregion
    }
}
