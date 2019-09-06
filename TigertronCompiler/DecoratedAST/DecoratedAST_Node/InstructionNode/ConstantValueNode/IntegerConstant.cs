using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class IntegerConstantNode : SimpleConstantNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        private int _value;
        public int Value
        {
            get { return _value; }
        }

        #endregion

        #region	Builder Methods

        public IntegerConstantNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            try
            {
                _value = int.Parse(Text);
                ReturnType = TypeExpression.IntType;
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            catch (Exception)
            {
                errors.Add(new Error("Value was either too large or too small for an Integer", Line, CharPositionInLine));
                ReturnType = TypeExpression.ErrorType;
                return false;
            }
        }

        public override void GenCode(ICodeGenerator cg)
        {
            cg.GetGenerator.Emit(OpCodes.Ldc_I4, Value);
        }

        #endregion
    }
}
