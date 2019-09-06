using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{

    public class LetInstructionNode : InstructionNode,IBreakable
    {
        #region	Fields and Properties

        public bool HasBreak
        {
            get { return InstructionsBlock.HasBreak; }
        }

        public override TypeExpression ReturnType { get; set; }

        private List<DeclarationSeqNode> _declarationsBlock;
        public List<DeclarationSeqNode> DeclarationsBlock
        {
            get
            {
                if (_declarationsBlock == null)
                {
                    var declarationList = GetChild(0);
                    _declarationsBlock = new List<DeclarationSeqNode>();
                    for (int i = 0; i < declarationList.ChildCount; i++)
                        _declarationsBlock.Add(declarationList.GetChild(i) as DeclarationSeqNode);
                }
                return _declarationsBlock;
            }
        }

        private InstructionsSeqNode _instructionsBlock;
        public InstructionsSeqNode InstructionsBlock
        {
            get { return _instructionsBlock ?? (_instructionsBlock = GetChild(1) as InstructionsSeqNode); }
        }

        #endregion

        #region	Builder Methods

        public LetInstructionNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            symbolTable.OpenScope(ScopeType.Let);//defino un nuevo scope

            #region	UserError Management

            /*
             * La idea general es no aceptar errores que puedan influir en otros errores
             * 
             * como los errores en cada bloque pueden influir en los bloques siguientes, 
             * y las declaraciones influyen en las instrucciones
             * solo voy a chequear el cuerpo de las instrucciones si todas las declaraciones 
             * estuvieron bien, y si me encuentro un bloque de declaracion mal, paro
             * 
             */

            #endregion

            if (DeclarationsBlock.All(block => block.CheckSemantic(errors, symbolTable)))
            {
                if (InstructionsBlock.CheckSemantic(errors, symbolTable))
                {
                    ReturnType = InstructionsBlock.ReturnType;
                    symbolTable.CloseScope();
                    Scope = symbolTable.TopScope.Clone();
                    return true;
                }
            }
            ReturnType = TypeExpression.ErrorType;
            symbolTable.CloseScope();
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            foreach (var declarationSeqNode in DeclarationsBlock)
            {
                declarationSeqNode.GenCode(cg);
            }
            InstructionsBlock.GenCode(cg);
        }

        #endregion
    }
}
