using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    
    public class IdentifierNode : InstructionNode,IAssignable
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        
        private bool _isLValue;
        public bool IsLValue
        {
            get { return _isLValue; }
        }

        private string _identifierName;
        public string IdentifierName { get { return _identifierName ?? (_identifierName = GetChild(0).Text); } }

        #endregion

        #region	Builder Methods

        public IdentifierNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            StatementSymbol symbol;
            if (MappingDeclaration(IdentifierName,symbolTable,errors,Line,CharPositionInLine, out symbol))
            {
                if (symbol is FieldSymbol)
                {
                    FieldSymbol varSymbol = symbol as FieldSymbol;
                    ReturnType = varSymbol.VarType;
                    _isLValue = !varSymbol.IsReadOnly;
                    Scope = symbolTable.TopScope.Clone();
                    return true;
                }
                string message = string.Format("'{0}' is a function but is used like a variable", IdentifierName);
                errors.Add(new Error(message, Line, CharPositionInLine));
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            var fieldBuilder = Scope.MappingDeclaration<FieldSymbol>(IdentifierName).FieldBuilder;
            cg.GetGenerator.Emit(OpCodes.Ldsfld, fieldBuilder);
        }

        public void AssignValue(ICodeGenerator cg)
        {
            var fieldBuilder = Scope.MappingDeclaration<FieldSymbol>(IdentifierName).FieldBuilder;
            cg.GetGenerator.Emit(OpCodes.Stsfld, fieldBuilder);
        }

        #endregion
    }
}
