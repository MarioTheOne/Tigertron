using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class InstructionsSeqNode : InstructionNode,IBreakable,IAssignable
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        private bool _hasBreak;
        public bool HasBreak
        {
            get { return _hasBreak; }
        }

        private bool _isLValue;
        public bool IsLValue
        {
            get { return _isLValue; }
        }

        private List<InstructionNode> _instructions;
        public List<InstructionNode> Instructions
        {
            get
            {
                if (_instructions == null)
                {
                    _instructions = new List<InstructionNode>();
                    for (int i = 0; i < ChildCount; i++)
                        _instructions.Add(GetChild(i) as InstructionNode);
                }
                return _instructions;
            }
        }

        #endregion

        #region	Builder Methods

        public InstructionsSeqNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            //Check semantic of instructions and verify if has break
            foreach (IBreakable expr in Instructions.Where
                     (expr => expr.CheckSemantic(errors, symbolTable)).OfType<IBreakable>())
            {
                _hasBreak = _hasBreak || expr.HasBreak;
            }
            //check return type
            if (initErr == errors.Count)
            {
                ReturnType = (_hasBreak || Instructions.Count == 0) ? TypeExpression.VoidType
                                 : Instructions[Instructions.Count - 1].ReturnType;
                if (!(ReturnType is VoidType))//check if is assignable
                {
                    InstructionNode lastInstruction = Instructions[Instructions.Count - 1];
                    if (lastInstruction is IAssignable && ((IAssignable) lastInstruction).IsLValue)
                        _isLValue = true;
                }
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            for (int i = 0; i < Instructions.Count - 1; i++)
            {
                Instructions[i].GenCode(cg);
                if (Instructions[i].ReturnType != TypeExpression.VoidType)
                {
                    cg.GetGenerator.Emit(OpCodes.Pop);
                }
            }
            if (Instructions.Count > 0)
                Instructions[Instructions.Count - 1].GenCode(cg);
        }

        public void AssignValue(ICodeGenerator cg)
        {
            for (int i = 0; i < Instructions.Count - 1; i++)
            {
                Instructions[i].GenCode(cg);
                if (Instructions[i].ReturnType != TypeExpression.VoidType)
                {
                    cg.GetGenerator.Emit(OpCodes.Pop);
                }
            }
            ((IAssignable)Instructions[Instructions.Count - 1]).AssignValue(cg);
        }

        #endregion

        
    }
}
