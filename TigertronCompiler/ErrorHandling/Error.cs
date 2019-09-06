
namespace TigertronCompiler.ErrorHandling
{
    public class Error
    {
        #region	Fields and Properties

        private string _message;
        public string Message
        {
            get { return _message; }
        }

        private int _line;
        public int Line
        {
            get { return _line; }
        }

        private int _column;
        public int Column
        {
            get { return _column; }
        }

        private ErrorKind _errorKind;
        public ErrorKind ErrorKind
        {
            get { return _errorKind; }
        }

        #endregion

        #region	Builder Methods

        public Error(string message, int line, int column, ErrorKind errorKind)
        {
            _message = message;
            _line = line;
            _column = column;
            _errorKind = errorKind;
        }
        public Error(string message, int line, int column):this(message,line,column,ErrorKind.SemanticError)
        {
            
        }

        #endregion

        #region	Main Methods

        public override string ToString()
        {
            return string.Format("({0},{1}): {2}(\"{3}\")", Line, Column, ErrorKind, Message);
        }

        #endregion
    }
}
