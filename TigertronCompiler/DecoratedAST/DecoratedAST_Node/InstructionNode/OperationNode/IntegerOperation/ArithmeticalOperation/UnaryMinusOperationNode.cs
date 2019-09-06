using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class UnaryMinusOperationNode : UnaryOperationNode
    {
        #region	Builder Methods

        public UnaryMinusOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            //Check OperandInstr
            if (base.CheckSemantic(errors,symbolTable))
            {
                //TypeChecking
                if (Operand.ReturnType.PrimitiveType is IntegerType)
                {
                    Scope = symbolTable.TopScope.Clone();
                    ReturnType = TypeExpression.IntType;
                    return true;
                }
                string message = string.Format("Cannot convert source type {0} to target type 'int'",Operand.ReturnType);
                errors.Add(new Error(message, Line, CharPositionInLine));
                ReturnType = TypeExpression.ErrorType;
            }
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            Operand.GenCode(cg);
            var gen = cg.GetGenerator;
            gen.Emit(OpCodes.Ldc_I4_M1);
            gen.Emit(OpCodes.Mul);
        }

        #endregion
    }
}
