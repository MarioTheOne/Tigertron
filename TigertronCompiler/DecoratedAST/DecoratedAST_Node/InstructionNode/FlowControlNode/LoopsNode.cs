using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class LoopsNode : ConditionalFlowControlNode
    {
        #region	Fields and Properties

        private InstructionNode _iterationInstruction;
        public InstructionNode IterationInstr
        {
            get
            {
                return _iterationInstruction ??
                       (_iterationInstruction = GetChild(ChildCount - 1) as InstructionNode);
            }
        }

        #endregion

        #region	Builder Methods

        protected LoopsNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Auxiliar (Semantic Region)

        protected override bool CheckInstructions(List<Error> errors, SymbolTable symbolTable)
        {
            bool bodyOk = IterationInstr.CheckSemantic(errors, symbolTable);
            symbolTable.CloseScope();//cierro el scope que inicialize en CheckCondition
            if (bodyOk) return true;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        protected override bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            TypeExpression iterType = IterationInstr.ReturnType;
            if (iterType is VoidType)
            {
                ReturnType = TypeExpression.VoidType;
                return true;
            }
            string message = string.Format("The type of a loop's body expression must be void");
            errors.Add(new Error(message, IterationInstr.Line, IterationInstr.CharPositionInLine));
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}
