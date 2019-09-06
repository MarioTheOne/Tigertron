using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class FunctionDeclarationNode : CallableExprDeclarationNode
    {
        #region	Builder Methods

        public FunctionDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	AuxiliarMethods

        protected override bool CheckExpectedType(SymbolTable symbolTable, List<Error> errors, out TypeExpression expectedType)
        {
            string typeSignature = GetChild(3).Text;
            int line = GetChild(3).Line;
            int col = GetChild(3).CharPositionInLine;
            TypeSymbol symbol;
            if (MappingDeclaration(typeSignature, symbolTable, errors, line, col, out symbol))
            {
                expectedType = symbol.TypeExpression;
                return true;
            }
            expectedType = null;
            return false;
        }

        #endregion
    }
}
