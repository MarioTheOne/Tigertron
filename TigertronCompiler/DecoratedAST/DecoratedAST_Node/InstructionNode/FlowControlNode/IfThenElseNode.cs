using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class IfThenElseNode : ConditionalJumpNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }
        private InstructionNode _elseInstruction;
        public InstructionNode ElseInstruction
        {
            get { return _elseInstruction ?? (_elseInstruction=(GetChild(2) as InstructionNode)); }
        }
        
        #endregion

        #region	Builder Methods

        public IfThenElseNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var endLabel = gen.DefineLabel();
            var elseLabel = gen.DefineLabel();

            ConditionExp.GenCode(cg);
            gen.Emit(OpCodes.Brfalse, elseLabel);//Si la condicion es falsa salto al else

            ThenInstruction.GenCode(cg);
            gen.Emit(OpCodes.Br, endLabel);//si fue verdadera despues de generar el thenInstruction y salto a la endLabel para terminar

            gen.MarkLabel(elseLabel);
            ElseInstruction.GenCode(cg);//si salte al else genero el ElseInstruction y termino

            gen.MarkLabel(endLabel);
        }

        #endregion

        #region	Auxiliar (Check Semantic)

        protected override bool CheckInstructions(List<Error> errors, SymbolTable symbolTable)
        {
            //Check ThenInstruccion
            bool thenOk = base.CheckInstructions(errors, symbolTable);
            //Check ElseInstruction
            bool elseOk = ElseInstruction.CheckSemantic(errors, symbolTable);
            //Check hasBreak
            if (ElseInstruction is IBreakable && (ElseInstruction as IBreakable).HasBreak) hasBreak = true;
            if (elseOk) return thenOk;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        protected override TypeExpression ExpectedType()
        {
            TypeMessage = "The second and third expressions of IfThenElse instruction must be of the same type or both not return a value";
            return ElseInstruction.ReturnType;
        }

        #endregion
    }
}
