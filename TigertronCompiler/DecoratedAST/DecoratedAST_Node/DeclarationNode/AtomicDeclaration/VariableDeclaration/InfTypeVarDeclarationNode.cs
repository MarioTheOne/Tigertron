using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler
{
    /// <summary>
    /// this class is for variable declarations where the variable type is infered
    /// </summary>
    public class InfTypeVarDeclarationNode : VarDeclarationNode
    {
        #region	 Builder Methods
        public InfTypeVarDeclarationNode(IToken payload)
            : base(payload)
        {
        }
        #endregion
        
        #region	Auxiliar Methods

        protected override bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            if (InitValue.ReturnType is NilType)
            {
                string message = "Cannot assign nil value to an implicitly-typed local variable." +
                                 " Nil must be used in a context were its actual type can be determined";
                errors.Add(new Error(message, Line, CharPositionInLine));
            }
            else if (InitValue.ReturnType is VoidType)
            {
                string message = "The rigth hand of assigment, must be a non-valueless expression";
                errors.Add(new Error(message,Line,CharPositionInLine));
            }
            else
            {
                VarType = InitValue.ReturnType;
                return true;
            }
            return false;
        }

        #endregion
    }
}
