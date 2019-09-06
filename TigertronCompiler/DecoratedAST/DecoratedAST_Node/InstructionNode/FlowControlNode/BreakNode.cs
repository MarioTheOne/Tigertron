using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class BreakNode : FlowControlNode,IBreakable
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        public bool HasBreak { get { return true; } }//caso base
        #endregion

        #region	Builder Methods

        public BreakNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            for (Scope InnerScope = symbolTable.TopScope; InnerScope != null; InnerScope = InnerScope.Outer)
            {
                if (InnerScope.ScopeType == ScopeType.Loop)//Esta dentro de un ciclo: OK
                {
                    Scope = symbolTable.TopScope.Clone();
                    ReturnType = TypeExpression.VoidType;
                    return true;
                }
                if (InnerScope.ScopeType == ScopeType.Function)//Esta dentro de una funcion: Function
                {
                    errors.Add(new Error("'break' statement can not appear inside function declaration", Line, CharPositionInLine));
                    ReturnType = TypeExpression.ErrorType;
                    return false;
                }
            }
            //Es el scope inicial y no tiene padre
            errors.Add(new Error("'break' expression must be inside 'for' or 'while' loop", Line, CharPositionInLine));
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(IntermediateCodeGeneration.ICodeGenerator cg)
        {
            cg.GetGenerator.Emit(OpCodes.Br, cg.LoopsEndLabels.Peek());//Salta a la etiqueta del fin del ciclo mas cercano
        }

        #endregion
    }
}
