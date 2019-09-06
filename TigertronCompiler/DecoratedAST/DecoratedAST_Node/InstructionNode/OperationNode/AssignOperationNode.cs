using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class AssignmentOperationNode : BinaryOperationNode
    {
        #region	Fields and Properties

        //Note: recordar que aqui el LValue es el hijo derecho
        private InstructionNode _leftOperand;
        public override InstructionNode LeftOperand
        {
            get { return _leftOperand ?? (_leftOperand = GetChild(1) as InstructionNode); }
        }

        private InstructionNode _rightOperand;
        public override InstructionNode RightOperand
        {
            get { return _rightOperand ?? (_rightOperand = GetChild(0) as InstructionNode); }
        }

        #endregion

        #region	Builder Methods

        public AssignmentOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckSemantic(errors, symbolTable))
            {
                //ya esta analizado que los dos sean del mismo tipo
                if (LeftOperand is IAssignable)
                {
                    IAssignable leftHand = LeftOperand as IAssignable;
                    if (leftHand.IsLValue)
                    {
                        Scope = symbolTable.TopScope.Clone();
                        ReturnType = TypeExpression.VoidType;
                        return true;
                    }
                    if (leftHand is IdentifierNode)//iteration var of for loop
                    {
                        string message = "The for iteration variable may not be assigned.";
                        errors.Add(new Error(message, RightOperand.Line, RightOperand.CharPositionInLine));
                    }
                    else//access to invalid lvalue
                    {
                        string message = "The left-hand side may not be used as an assigment target.";
                        errors.Add(new Error(message, RightOperand.Line, RightOperand.CharPositionInLine));
                    }
                }
                else//function call, constant (Note:grammar allow this expressions as LValue)
                {
                    string message = "The left-hand side may not be used as an assigment target.";
                    errors.Add(new Error(message, RightOperand.Line, RightOperand.CharPositionInLine));
                }
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            RightOperand.GenCode(cg);
            (LeftOperand as IAssignable).AssignValue(cg);
        }

        #endregion
    }
}
