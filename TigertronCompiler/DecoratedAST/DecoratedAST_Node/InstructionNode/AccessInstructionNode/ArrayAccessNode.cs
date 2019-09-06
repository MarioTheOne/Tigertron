using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class ArrayAccessNode : AccessInstructionNode, IAssignable
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        private InstructionNode _indexInstruction;
        public InstructionNode IndexInstruction
        {
            get { return _indexInstruction ?? (_indexInstruction = (GetChild(0) as InstructionNode)); }
        }

        private bool _isLValue;
        public bool IsLValue
        {
            get { return _isLValue; }
        }

        #endregion

        #region	Builder Methods

        public ArrayAccessNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckSemantic(errors, symbolTable) & IndexInstruction.CheckSemantic(errors, symbolTable))
            {
                TypeExpression resultType = LValue.ReturnType.SubscriptAt(IndexInstruction.ReturnType);
                if (resultType is ErrorType)
                    errors.Add(new Error((resultType as ErrorType).Message, Line, CharPositionInLine));
                else
                {
                    ReturnType = resultType;
                    _isLValue = (LValue is IAssignable);
                    Scope = symbolTable.TopScope.Clone();
                    return true;
                }
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }


        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            ArrayType arrayType = (LValue.ReturnType.PrimitiveType as ArrayType);
            LValue.GenCode(cg);
            IndexInstruction.GenCode(cg);
            gen.Emit(OpCodes.Ldelem, arrayType.BaseType.ILType);
        }

        public void AssignValue(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            ArrayType arrayType = (LValue.ReturnType.PrimitiveType as ArrayType);
            LocalBuilder aux = gen.DeclareLocal(arrayType.BaseType.ILType);
            gen.Emit(OpCodes.Stloc, aux);
            LValue.GenCode(cg);
            IndexInstruction.GenCode(cg);
            gen.Emit(OpCodes.Ldloc, aux);
            gen.Emit(OpCodes.Stelem, arrayType.BaseType.ILType);
        }

        #endregion
    }
}
