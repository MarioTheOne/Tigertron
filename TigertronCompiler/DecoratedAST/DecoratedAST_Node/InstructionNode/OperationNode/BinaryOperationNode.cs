using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class BinaryOperationNode : OperationNode
    {
        #region	Fields and Properties

        private InstructionNode _leftOperand;
        public virtual InstructionNode LeftOperand
        {
            get { return _leftOperand ?? (_leftOperand = GetChild(0) as InstructionNode); }
        }

        private InstructionNode _rightOperand;
        public virtual InstructionNode RightOperand
        {
            get { return _rightOperand ?? (_rightOperand = GetChild(1) as InstructionNode); }
        }

        #endregion

        #region	Builder Methods

        protected BinaryOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            //Check Operands
            if (LeftOperand.CheckSemantic(errors, symbolTable) & RightOperand.CheckSemantic(errors, symbolTable))
            {
                //Check: ILType Equals
                if (LeftOperand.ReturnType.IsEquivalent(RightOperand.ReturnType)) return true;

                string message = string.Format("Could not applied operation '{0}' between operands of types '{1}' and '{2}'",
                                                                     Text, LeftOperand.ReturnType, RightOperand.ReturnType);
                errors.Add(new Error(message, Line, CharPositionInLine));
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}

