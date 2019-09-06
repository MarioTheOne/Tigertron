
namespace TigertronCompiler.SymbolTableManagement.SymbolNode
{
    public abstract class Symbol
    {
        #region	Properties

        public string Identifier { get; set; }

        /// <summary>
        /// esta propiedad me dice si no ocurrio ningun error semantico y puedo usar la informacion del simbolo en el chequeo semantico
        /// </summary>
        public bool IsDefined { get; set; }

        #endregion

        #region	BuilderMethod

        protected Symbol(string identifier)
        {
            Identifier = identifier;
            IsDefined = true;//Note: esto lo voy a cambiar si dio falso en el check semantic
        }

        #endregion
    }
}
