
namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public abstract class CompositeType : TypeExpression
    {
        #region	Properties

        public long ScopeId { get; private set; }
        public TypeConstructor TypeConstructor { get; private set; }

        #endregion

        #region	BuilderMethods

        protected CompositeType(string identifier, TypeConstructor typeConstructor, long scopeId)
            : base(identifier)
        {
            TypeConstructor = typeConstructor;
            ScopeId = scopeId;
        }

        #endregion

        #region	Main Methods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            if (otherType is NilType && IsNullable) return true;
            if (!(otherType.PrimitiveType is CompositeType)) return false;
            return (Identifier == otherType.PrimitiveType.Identifier) &&
                   (ScopeId == ((CompositeType) otherType.PrimitiveType).ScopeId);
        }

        #endregion
    }
}
