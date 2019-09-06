namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public abstract class BuiltInType : TypeExpression
    {
        #region	Properties

        public override TypeExpression PrimitiveType
        {
            get { return this; }
        }

        #endregion

        #region	BuilderMethods

        protected BuiltInType(string identifier)
            : base(identifier)
        {

        }

        #endregion
    }
}
