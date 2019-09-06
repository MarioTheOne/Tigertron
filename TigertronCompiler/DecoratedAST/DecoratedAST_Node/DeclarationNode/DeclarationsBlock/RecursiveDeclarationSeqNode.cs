using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class RecursiveDeclarationSeqNode : DeclarationSeqNode
    {
        #region	BuilderMethod

        protected RecursiveDeclarationSeqNode(IToken payload)
            : base(payload)
        {
        }

        #endregion

        #region	MainMethods

        public override bool CheckSemantic(List<ErrorHandling.Error> errors, SymbolTable symbolTable)
        {
            //Note: hago el prechequeo, conflicto de nombres y voy guardando los headers de las declaraciones en la tabla de simbolos
            bool firstPass = CheckHeaderSemantic(errors, symbolTable);
            //Note: hago un chequeo mas completo de la parte derecha de las declaraciones
            bool secondPass = base.CheckSemantic(errors, symbolTable);
            if (firstPass && secondPass)
            {
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            return false;
        }

        #endregion
    }
}
