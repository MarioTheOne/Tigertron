using System;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    /// <summary>
    /// this type denote the absence of a value
    /// </summary>
    public class VoidType : BuiltInType
    {
        #region	Properties

        public override Type ILType
        {
            get { return typeof(void); }
            set { }
        }

        #endregion

        #region	BuilderMethod

        public VoidType()
            : base("void")
        {

        }

        #endregion

        #region	Main Methods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return otherType is VoidType;
        }

        public override void DefineType(ICodeGenerator cg)
        {
            ILType = typeof(void);
        }

        #endregion

        public override bool IsNullable
        {
            get { return false; }
        }
    }
}
