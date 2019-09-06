
namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class NilType : AuxiliarType
    {
        #region	Builder Methods

        public NilType()
            : base("nil")
        {
        }

        #endregion

        #region	Properties

        public override TypeExpression PrimitiveType
        {
            get { return this; }
        }

        public override bool IsNullable
        {
            get { return true; }
        }

        #endregion

        #region	MainMethods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return otherType.IsNullable;
        }

        public override TypeExpression SubscriptAt(TypeExpression index)
        {
            return new ErrorType("Expression might not be initialized berfore accesing");
        }

        public override TypeExpression ExtractField(string fieldName)
        {
            return new ErrorType("Expression might not be initialized berfore accesing");
        }

        public override string ToString()
        {
            return "a nil value";
        }

        #endregion
    }
}
