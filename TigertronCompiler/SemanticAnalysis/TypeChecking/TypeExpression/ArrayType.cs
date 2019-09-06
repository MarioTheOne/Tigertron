using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class ArrayType : CompositeType
    {
        #region	Properties

        public TypeExpression BaseType { get; set; }
        public override TypeExpression PrimitiveType
        {
            get { return this; }
        }
        public override bool IsNullable
        {
            get { return true; }
        }

        #endregion

        #region	Builder Method

        public ArrayType(string identifier, TypeExpression type, long scopeId)
            : base(identifier, TypeConstructor.Array,scopeId)
        {
            BaseType = type;
        }

        #endregion

        #region	Main Method

        public override TypeExpression SubscriptAt(TypeExpression index)
        {
            return (index.PrimitiveType is IntegerType) 
                ? BaseType
                : new ErrorType(string.Format("Argument type \"{0}\" is not assignable to parameter type int",index.Identifier));
        }

        public override string ToString()
        {
            return string.Format("{0}: \"array of {1}\"", Identifier, BaseType);
        }

        public override void DefineType(ICodeGenerator cg)
        {
            if (BaseType.ILType == null) BaseType.DefineType(cg);
            ILType = BaseType.ILType.MakeArrayType();
        }

        #endregion
    }
}
