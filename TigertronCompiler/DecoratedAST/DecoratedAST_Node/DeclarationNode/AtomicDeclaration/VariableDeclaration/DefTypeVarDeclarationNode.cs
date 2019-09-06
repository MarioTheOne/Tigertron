using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler
{
    /// <summary>
    /// this class is for variable declarations where the variable type is defined
    /// </summary>
    public class DefTypeVarDeclarationNode : VarDeclarationNode
    {
        #region	 Builder Methods
        public DefTypeVarDeclarationNode(IToken payload)
            : base(payload)
        {
        }
        #endregion

        #region	Auxiliar Methods

        protected override bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            //Check VarType
            var typeDef = GetChild(2);
            TypeSymbol varTypeSymbol;
            if (MappingDeclaration(typeDef.Text, symbolTable, errors, typeDef.Line, typeDef.CharPositionInLine,out varTypeSymbol))
            {
                if (CheckAssigment(InitValue, varTypeSymbol.TypeExpression, errors))
                {
                    VarType = varTypeSymbol.TypeExpression;
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
