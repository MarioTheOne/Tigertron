using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class StatementDeclarationNode : AtomicDeclarationNode
    {
        #region	BuilderMethod

        protected StatementDeclarationNode(IToken payload)
            : base(payload)
        {
        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckHeaderSemantic(errors, symbolTable))
            {
                //verifico si puedo usar una variable con el nombre de IterationVar(no puede sobreescribir a ninguna variable de iteracion)
                //lo hago aki porke las funciones y variables comparten el mismo namespace
                if (!symbolTable.IsThereIterationVar(Identifier)) return true;
                errors.Add(new Error("Iteration var of a for loop cannot be hidden", Line, CharPositionInLine));
            }
            return false;
        }

        #endregion

        #region	Auxiliar Methods

        protected override bool CheckUniverseConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            StatementSymbol universeSymbol = symbolTable.GetUniverseDeclaration<StatementSymbol>(Identifier);
            if (universeSymbol != null)
            {
                errors.Add(new Error("Function's names of standard library could not be used in declarations", Line, CharPositionInLine));
                return false;
            }
            return true;
        }
        protected override bool CheckLocalConflicts(List<Error> errors, SymbolTable symbolTable)
        {
            if (symbolTable.GetLocalDeclaration<StatementSymbol>(Identifier) != null)
            {
                errors.Add(new Error(string.Format("There is already a variable or function with identifier: '{0}' in current scope", Identifier), Line, CharPositionInLine));
                return false;
            }
            return true;
        }

        #endregion
    }
}
