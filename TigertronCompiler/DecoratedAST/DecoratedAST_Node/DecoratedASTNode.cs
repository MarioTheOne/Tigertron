using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class DecoratedASTNode : CommonTree
    {
        #region	Field and Properties

        public Scope Scope { get; set; }

        #endregion
        
        #region	BuilderMethod

        protected DecoratedASTNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        

        #region	Auxiliar Methods

        protected bool MappingDeclaration<T>(string identifier, SymbolTable symbolTable, List<Error> errors,
                                            int line, int col, out T symbol) where T : Symbol
        {
            symbol = symbolTable.MappingDeclaration<T>(identifier);
            if (symbol == null)
            {
                string message = string.Format("The name '{0}' does not exist in the current context", identifier);
                errors.Add(new Error(message, line, col));
                return false;
            }
            if (!symbol.IsDefined)
            {
                string message = string.Format("Cannot resolve definition of symbol '{0}'", identifier);
                errors.Add(new Error(message, line, col));
                return false;
            }
            return true;
        }

        #endregion
    }
}
