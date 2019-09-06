using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class StringConstantNode : SimpleConstantNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        private string _value;
        public string Value
        {
            get
            {
                if (_value == null)
                {
                    //FormatString
                    _value = "";
                    string payload = Text.Substring(1, Text.Length - 2);

                    for (int i = 0; i < payload.Length; i++)
                    {
                        if (payload[i] != '\\')
                            _value += payload[i];
                        else
                        {
                            i++;//veo cual es el proximo caracter
                            switch (payload[i])
                            {
                                case 'n':
                                    _value += '\n';
                                    break;
                                case 'r':
                                    _value += '\r';
                                    break;
                                case 't':
                                    _value += '\t';
                                    break;
                                case '\"':
                                    _value += '\"';
                                    break;
                                case '\\':
                                    _value += '\\';
                                    break;
                                case '^':
                                    i++;
                                    _value += (char)(payload[i] - 64);
                                    break;
                                default:
                                    if (payload[i] >= 48 && payload[i] < 57)
                                    {
                                        _value += (char)(int.Parse(payload.Substring(i, 3)));
                                        i += 2;
                                    }
                                    else //-> \...(WS)+...\
                                        i = payload.IndexOf('\\', i + 1);
                                    break;
                            }
                        }
                    }
                }
                return _value;
            }
        }

        #endregion

        #region	Builder Methods

        public StringConstantNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            Scope = symbolTable.TopScope.Clone();
            ReturnType = TypeExpression.StringType;
            return true;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            cg.GetGenerator.Emit(OpCodes.Ldstr, Value);
        }

        #endregion
    }
}
