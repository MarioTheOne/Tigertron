using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class ArrayDeclarationNode : TypeDeclarationNode
    {
        #region	Fields and Properties

        private bool _isValid;

        private string _baseTypeId;
        public string BaseTypeId
        {
            get { return _baseTypeId ?? (_baseTypeId = GetChild(1).Text); }
        }

        #endregion

        #region	Builder Methods

        public ArrayDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckHeaderSemantic(errors, symbolTable))
            {
                ProcessDeclaration(symbolTable);
                _isValid = true;
                return true;
            }
            _isValid = false;
            return false;
        }

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (_isValid)
            {
                int initErr = errors.Count;

                //obtengo el tipo para modificarle su base

                TypeSymbol typeSymbol;
                if (MappingDeclaration(Identifier, symbolTable, errors, Line, CharPositionInLine, out typeSymbol))
                {
                    ArrayType arrayType = typeSymbol.TypeExpression as ArrayType;

                    // check BaseType
                    TypeSymbol baseTypeSymbol;
                    if (MappingDeclaration(BaseTypeId, symbolTable, errors, GetChild(1).Line,
                                           GetChild(1).CharPositionInLine, out baseTypeSymbol))
                    {
                        arrayType.BaseType = baseTypeSymbol.TypeExpression;
                        TypeExpression = arrayType;
                    }
                }

                if (initErr == errors.Count)
                {
                    Scope = symbolTable.TopScope.Clone();
                    return true;
                }
                symbolTable.InvalidateDeclaration<TypeSymbol>(Identifier);
            }
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            if (TypeExpression.ILType == null) TypeExpression.DefineType(cg);
        }

        #endregion

        #region	Auxiliar Methods

        protected override void ProcessDeclaration(SymbolTable symbolTable)
        {
            TypeExpression type = new ArrayType(Identifier,null,symbolTable.TopScope.Id);
            symbolTable.InsertDeclaration(new TypeSymbol(type));
        }

        #endregion
    }
}
