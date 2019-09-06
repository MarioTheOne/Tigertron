using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class ConditionalJumpNode : ConditionalFlowControlNode,IBreakable
    {
        #region	Fields and Properties

        protected string TypeMessage { get; set; }

        private InstructionNode _thenInstruction;
        public InstructionNode ThenInstruction
        {
            get { return _thenInstruction??(_thenInstruction = (GetChild(1) as InstructionNode)); }
        }

        protected bool hasBreak;
        public bool HasBreak
        {
            get { return hasBreak; }
        }
        #endregion

        #region	Builder Methods

        protected ConditionalJumpNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Auxiliar (Check Semantic)

        protected override bool CheckInstructions(List<Error> errors, SymbolTable symbolTable)
        {
            //Note: aqui mismo actualizo el hasBreak, para no tener ke pasar otra vez por cada instruccion
            //Note: aqui mismo actualizo el ReturnType en caso de error para ke TypeChecking solo se encargue del checkeo correcto de tipos

            //Check ThenInstruccion
            bool thenOk = ThenInstruction.CheckSemantic(errors, symbolTable);
            hasBreak = (ThenInstruction is IBreakable && (ThenInstruction as IBreakable).HasBreak);
            if (thenOk) return true;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }
        protected override bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            TypeExpression thenType = ThenInstruction.ReturnType;
            TypeExpression expectedType = ExpectedType();
            if (thenType.IsEquivalent(expectedType))
            {
                ReturnType = (expectedType.PrimitiveType is BuiltInType) ? expectedType.PrimitiveType : expectedType;
                return true;
            }
            string message = string.Format("Could not convert type : '{0}' to '{1}'. {2}", thenType, expectedType, TypeMessage);
            errors.Add(new Error(message, ThenInstruction.Line, ThenInstruction.CharPositionInLine));
            ReturnType = TypeExpression.ErrorType;
            return false;
        }
        protected virtual TypeExpression ExpectedType()
        {
            return null;
        }

        #endregion
    }
}
