using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class DeclarationSeqNode : DeclarationNode
    {
        #region	Properties

        private List<AtomicDeclarationNode> _declarations;
        public List<AtomicDeclarationNode> Declarations
        {
            get
            {
                if (_declarations == null)
                {
                    _declarations = new List<AtomicDeclarationNode>();
                    for (int i = 0; i < ChildCount; i++)
                        _declarations.Add(GetChild(i) as AtomicDeclarationNode);
                }
                return _declarations;
            }
        }

        #endregion

        #region	BuilderMethod

        protected DeclarationSeqNode(IToken payload)
            : base(payload)
        {
        }

        #endregion

        #region	MainMethods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            bool succesful = true;
            foreach (var declaration in Declarations)
                if (!declaration.CheckSemantic(errors, symbolTable))
                    succesful = false;
            if (succesful)
            {
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            return false;
        }
        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            bool succesful = true;
            foreach (var declaration in Declarations)
                if (!declaration.CheckHeaderSemantic(errors,symbolTable))
                    succesful = false;
            return succesful;
        }

        public override void GenCode(IntermediateCodeGeneration.ICodeGenerator cg)
        {
            foreach (AtomicDeclarationNode declaration in Declarations)
            {
                declaration.GenCode(cg);
            }
        }

        #endregion
    }
}
