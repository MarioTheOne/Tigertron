using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class RecordDeclarationNode : TypeDeclarationNode
    {
        #region	Fields and Properties

        private bool _isValid;

        private List<FieldNode> _fields;
        public List<FieldNode> Fields
        {
            get
            {
                if (_fields == null)
                {
                    _fields = new List<FieldNode>();
                    var fieldList = GetChild(1);
                    for (int i = 0; i < fieldList.ChildCount; i++)
                        _fields.Add(fieldList.GetChild(i) as FieldNode);
                }
                return _fields;
            }
        }

        #endregion

        #region	Builder Methods

        public RecordDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            if (base.CheckHeaderSemantic(errors, symbolTable))
            {
                //Does not exist two fields of records with the same name
                for (int i = 0; i < Fields.Count - 1; i++)
                {
                    for (int j = i + 1; j < Fields.Count; j++)
                    {
                        if (Fields[i].Identifier == Fields[j].Identifier)
                        {
                            string message = string.Format("The field id '{0}' already exist in this record type", Fields[i].Identifier);
                            errors.Add(new Error(message, Fields[j].Line, Fields[j].CharPositionInLine));
                        }
                    }
                }
                if (initErr == errors.Count)
                {
                    ProcessDeclaration(symbolTable);
                    _isValid = true;
                    return true;
                }
                ProcessUndefinedDeclaration(symbolTable);
            }
            _isValid = false;
            return false;
        }

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (_isValid)
            {
                ;
                int initErr = errors.Count;

                //obtengo el tipo para modificarle sus campos
                TypeSymbol typeSymbol;
                if (MappingDeclaration(Identifier, symbolTable, errors, Line, CharPositionInLine, out typeSymbol))
                {
                    RecordType recordType = typeSymbol.TypeExpression as RecordType;

                    //Check fields
                    foreach (var fieldNode in Fields)
                        if (fieldNode.CheckSemantic(errors, symbolTable))
                            recordType.Fields[fieldNode.Identifier] = fieldNode.FieldType;

                    TypeExpression = recordType;
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
            Dictionary<string,TypeExpression> fieldHeader = new Dictionary<string, TypeExpression>();
            foreach (var fieldNode in Fields)
                fieldHeader.Add(fieldNode.Identifier,null);//despues lo enlazo por referencia
            TypeExpression type = new RecordType(Identifier, fieldHeader,symbolTable.TopScope.Id);
            symbolTable.InsertDeclaration(new TypeSymbol(type));
        }

        protected override void ProcessUndefinedDeclaration(SymbolTable symbolTable)
        {
            TypeExpression type = new RecordType(Identifier, null,symbolTable.TopScope.Id);
            symbolTable.InsertDeclaration(new TypeSymbol(type));
            symbolTable.InvalidateDeclaration<TypeSymbol>(Identifier);
        }

        
        #endregion
    }
}
