using System;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class StringType : BuiltInType
    {
        #region	Properties

        public override Type ILType
        {
            get { return typeof(string); }
            set { }
        }

        public override bool IsNullable
        {
            get { return true; }
        }

        #endregion

        #region	BuilderMethod

        public StringType()
            : base("string")
        {

        }

        #endregion

        #region	Main Method

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return (otherType.PrimitiveType is StringType) || (otherType is NilType);
        }

        public override void DefineType(ICodeGenerator cg)
        {
            ILType = typeof(string);
        }

        #endregion
    }
}

