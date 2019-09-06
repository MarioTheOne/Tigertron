using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class AliasDeclarationNode : TypeDeclarationNode
    {
        #region	Fields and Properties

        private bool _isValid;
        private string _originalType;
        public string OriginalTypeId
        {
            get { return _originalType ?? (_originalType = GetChild(1).Text); }
        }

        #endregion

        #region	Builder Methods

        public AliasDeclarationNode(IToken payload)
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

                //obtengo el tipo para modificarle su original type
                TypeSymbol typeSymbol;
                if (MappingDeclaration(Identifier,symbolTable,errors,Line,CharPositionInLine,out typeSymbol))
                {
                    AliasType aliasType = typeSymbol.TypeExpression as AliasType;
                    TypeSymbol origTypeSymbol;
                    //check BaseType
                    if (MappingDeclaration(OriginalTypeId, symbolTable, errors, GetChild(1).Line, GetChild(1).CharPositionInLine,
                                           out origTypeSymbol))
                    {
                        aliasType.RenamedType = origTypeSymbol.TypeExpression;
                        TypeExpression = aliasType;
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
            TypeExpression type = new AliasType(null, Identifier, symbolTable.TopScope.Id);
            symbolTable.InsertDeclaration(new TypeSymbol(type));
        }

        #endregion
    }
}
