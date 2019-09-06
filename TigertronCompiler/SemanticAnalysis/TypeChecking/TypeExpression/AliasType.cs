using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class AliasType : CompositeType
    {
        #region	Properties

        public TypeExpression RenamedType { get; set; }
        public override TypeExpression PrimitiveType
        {
            get { return RenamedType.PrimitiveType; }
        }
        public override bool IsNullable
        {
            get { return PrimitiveType.IsNullable; }
        }

        #endregion

        #region	Builder Method

        public AliasType(TypeExpression renamedType, string targetName, long scopeId)
            : base(targetName, TypeConstructor.Alias, scopeId)
        {
            RenamedType = renamedType;
        }

        #endregion

        #region	Main Methods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return PrimitiveType.IsEquivalent(otherType);
        }

        public override TypeExpression ExtractField(string fieldName)
        {
            return PrimitiveType.ExtractField(fieldName);
        }

        public override TypeExpression SubscriptAt(TypeExpression index)
        {
            return PrimitiveType.SubscriptAt(index);
        }

        public override string ToString()
        {
            return string.Format("{0} :\" alias of {1}\"",Identifier,PrimitiveType);
        }

        public override void DefineType(ICodeGenerator cg)
        {
            if (PrimitiveType.ILType == null) PrimitiveType.DefineType(cg);
            ILType = PrimitiveType.ILType;
        }

        #endregion
    }
}
