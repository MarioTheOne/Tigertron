using Antlr.Runtime;
using System.Collections.Generic;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class FieldNode : DecoratedASTNode
    {
        #region	Fields and Properties

        public TypeExpression FieldType { get; set; }
        public string Identifier { get { return GetChild(0).Text; } }

        private string TypeId { get { return GetChild(1).Text; } }

        #endregion

        #region	Builder Methodsp

        public FieldNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            TypeSymbol symbol;//Check ILType
            if (MappingDeclaration(TypeId,symbolTable,errors,Line,CharPositionInLine,out symbol))
            {
                Scope = symbolTable.TopScope.Clone();
                FieldType = symbol.TypeExpression;
                return true;
            }
            FieldType = TypeExpression.ErrorType;
            return false;
        }

        #endregion

    }
}
