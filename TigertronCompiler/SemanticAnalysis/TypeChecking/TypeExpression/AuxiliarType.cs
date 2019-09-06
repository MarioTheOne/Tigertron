namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public abstract class AuxiliarType : TypeExpression
    {
        #region	Properties

        public override TypeExpression PrimitiveType
        {
            get { return this; }
        }
        

        #endregion

        #region	BuilderMethods

        protected AuxiliarType(string identifier)
            : base(identifier)
        {

        }

        #endregion
    }
}
