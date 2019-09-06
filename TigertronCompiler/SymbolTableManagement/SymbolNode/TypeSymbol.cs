using System;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler.SymbolTableManagement.SymbolNode
{
    public class TypeSymbol : Symbol
    {
        #region	Properties

        public TypeExpression TypeExpression { get; set; }
        public Type ILType { get { return TypeExpression.ILType; } set { TypeExpression.ILType = value; } }

        #endregion

        #region	BuilderMethod

        public TypeSymbol(TypeExpression typeExpression)
            : base(typeExpression.Identifier)
        {
            TypeExpression = typeExpression;
        }

        #endregion
    }
}
