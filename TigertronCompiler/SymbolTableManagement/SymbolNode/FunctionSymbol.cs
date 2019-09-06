using System.Reflection.Emit;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using System.Collections.Generic;

namespace TigertronCompiler.SymbolTableManagement.SymbolNode
{
    public class FunctionSymbol : StatementSymbol
    {
        #region	Properties

        public TypeExpression ReturnType { get; private set; }
        public List<KeyValuePair<string,TypeExpression>> Params { get; private set; }

        public MethodBuilder MethodBuilder { get; set; }

        public List<FieldBuilder> ParameterFieldBuilders { get; set; }
        public long BodyScopeId { get; set; }


        #endregion

        #region	BuilderMethods

        public FunctionSymbol(string identifier, TypeExpression returnType, List<KeyValuePair<string, TypeExpression>> parameters)
            : base(identifier)
        {
            ReturnType = returnType;
            Params = parameters;
        }

        #endregion
    }
}
