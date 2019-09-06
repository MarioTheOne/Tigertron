using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class VarDeclarationNode : StatementDeclarationNode
    {
        #region	Properties

        //this property will be setted in CheckSemantic method
        public TypeExpression VarType { get; set; }
        private InstructionNode _initValue;
        public InstructionNode InitValue
        {
            get { return _initValue ?? (_initValue = GetChild(1) as InstructionNode); }
        }

        #endregion

        #region	BuilderMethod

        protected VarDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (CheckHeaderSemantic(errors, symbolTable))
            {
                if (InitValue.CheckSemantic(errors, symbolTable) && TypeChecking(errors, symbolTable))
                {
                    ProcessDeclaration(symbolTable);
                    Scope = symbolTable.TopScope.Clone();
                    return true;
                }
                ProcessUndefinedDeclaration(symbolTable);
            }
            else
                InitValue.CheckSemantic(errors, symbolTable);
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            var fieldBuilder = cg.TypeBuilder.DefineField(Identifier + "_" + Scope.Id, VarType.ILType, FieldAttributes.Public | FieldAttributes.Static);
            InitValue.GenCode(cg);
            cg.GetGenerator.Emit(OpCodes.Stsfld, fieldBuilder);
            Scope.MappingDeclaration<FieldSymbol>(Identifier).FieldBuilder = fieldBuilder;
        }

        #endregion

        #region	Auxiliar Methods

        protected override void ProcessDeclaration(SymbolTable symbolTable)
        {
            //almaceno esta variable en su scope
            symbolTable.InsertDeclaration(new FieldSymbol(Identifier, VarType));
        }

        protected override void ProcessUndefinedDeclaration(SymbolTable symbolTable)
        {
            symbolTable.InsertDeclaration(new FieldSymbol(Identifier, null));
            symbolTable.InvalidateDeclaration<FieldSymbol>(Identifier);
        }

        protected virtual bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            return true;
        }

        #endregion
    }
}
