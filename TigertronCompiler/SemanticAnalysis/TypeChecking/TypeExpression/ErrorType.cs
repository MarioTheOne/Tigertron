namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class ErrorType : AuxiliarType
    {
        #region	Properties

        //este mensaje solo lo usare a la hora de la inferencia de tipos
        public string Message { get; private set; }

        public override bool IsNullable
        {
            get { return false; }
        }

        #endregion

        #region	BuilderMethod

        public ErrorType()
            : base("Semantic UserError")
        {
            //este es para cuando no me interesa el mensaje
        }

        public ErrorType(string message)
            : base("Semantic UserError")
        {
            Message = message;
        }

        #endregion

        #region	Main Methods

        public override bool IsEquivalent(TypeExpression otherType)
        {
            return otherType is ErrorType;
        }

        public override string ToString()
        {
            return string.Format("Semantic error: {0}", Message); 
        }

        #endregion
    }
}
