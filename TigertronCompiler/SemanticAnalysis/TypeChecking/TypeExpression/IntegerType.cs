using System;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class IntegerType : BuiltInType
    {
        #region	Properties

        public override bool IsNullable
        {
            get { return false; }
        }

        public override Type ILType
        {
            get { return typeof(int); } set { }
        }

        #endregion

        #region	BuilderMethod

        public IntegerType()
            : base("int")
        {

        }

        #endregion

        #region	Main Methods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return otherType.PrimitiveType is IntegerType;
        }

        public override void DefineType(ICodeGenerator cg)
        {
            ILType = typeof(int);
        }

        #endregion
    }
}
