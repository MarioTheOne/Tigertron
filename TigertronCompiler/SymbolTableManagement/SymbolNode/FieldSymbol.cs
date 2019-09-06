using System.Reflection.Emit;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler.SymbolTableManagement.SymbolNode
{
    public class FieldSymbol : StatementSymbol
    {
        #region	Properties

        public TypeExpression VarType { get; set; }
        public bool IsReadOnly { get; private set; }

        public FieldBuilder FieldBuilder { get; set; }

        #endregion

        #region	BuilderMethod

        public FieldSymbol(string identifier, TypeExpression varType, bool isReadOnly)
            : base(identifier)
        {
            IsReadOnly = isReadOnly;
            VarType = varType;
        }

        public FieldSymbol(string identifier, TypeExpression varType):this(identifier,varType,false)
        {
            
        }

        #endregion
    }
}
