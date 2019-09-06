using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class AtomicDeclarationNode : DeclarationNode
    {
        #region	Properties

        private string _identifier;
        public string Identifier
        {
            get
            {
                return _identifier ?? (_identifier = GetChild(0).Text);
            }
        }

        #endregion

        #region	Builder Methods

        protected AtomicDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            return CheckUniverseConflicts(errors, symbolTable) && CheckLocalConflicts(errors, symbolTable);
        }

        #endregion

        #region	AuxiliarMethods Semantic

        /// <summary>
        /// este metodo verifica si hay conflicto de nombres con el universo de la tabal de simbolos
        /// </summary>
        protected virtual bool CheckUniverseConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            return false;
        }

        /// <summary>
        /// este metodo verifica si hay conflicto de nombres con las declaraciones que estan en su scope local
        /// </summary>
        protected virtual bool CheckLocalConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            return false;
        }

        protected virtual void ProcessDeclaration(SymbolTable symbolTable){}
        protected virtual void ProcessUndefinedDeclaration(SymbolTable symbolTable) { }

        #endregion
    }
}
