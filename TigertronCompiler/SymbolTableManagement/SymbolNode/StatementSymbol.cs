namespace TigertronCompiler.SymbolTableManagement.SymbolNode
{
    public abstract class StatementSymbol : Symbol
    {
        #region	BuilderMethod

        protected StatementSymbol(string identifier)
            : base(identifier)
        {
        }

        #endregion
    }
}
