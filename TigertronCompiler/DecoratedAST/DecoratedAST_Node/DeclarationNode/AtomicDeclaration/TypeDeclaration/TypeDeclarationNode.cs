using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class TypeDeclarationNode : AtomicDeclarationNode
    {
        #region	Fields and Properties

        //this property will be setted in CheckSemantic method
        public TypeExpression TypeExpression { get; set; }

        #endregion

        #region	Builder Methods

        protected TypeDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Auxiliar Region

        protected override bool CheckUniverseConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            //verifico si el tipo no es uno de los built-in types
            TypeSymbol universeSymbol = symbolTable.GetUniverseDeclaration<TypeSymbol>(Identifier);
            if (universeSymbol != null)
            {
                errors.Add(new Error("Identifiers of built-in types 'int' or 'string' could not be used in declarations", Line, CharPositionInLine));
                return false;
            }
            return true;
        }
        protected override bool CheckLocalConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            //verifico si no existe un tipo con el mismo identificador en el mismo nivel
            if (symbolTable.GetLocalDeclaration<TypeSymbol>(Identifier) != null)
            {
                errors.Add(new Error(string.Format("There is already a type with identifier: '{0}'", Identifier), Line, CharPositionInLine));
                return false;
            }
            return true;
        }
        
        #endregion
    }
}
