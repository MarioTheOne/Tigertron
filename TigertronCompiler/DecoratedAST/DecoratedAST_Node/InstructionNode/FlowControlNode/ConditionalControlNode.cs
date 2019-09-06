using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class ConditionalFlowControlNode : FlowControlNode
    {
        #region	Fields and Properties

        private InstructionNode _conditionExp;
        public InstructionNode ConditionExp
        {
            get { return _conditionExp ?? (_conditionExp = GetChild(0) as InstructionNode); }
        }
        //esta propiedad sera seteada en el metodo TypeChecking
        public override TypeExpression ReturnType { get; set; }

        

        #endregion

        #region	Builder Methods

        protected ConditionalFlowControlNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            bool cond = CheckCondition(errors, symbolTable);
            if (CheckInstructions(errors, symbolTable))//debo checkear todas las instrucciones
                if (TypeChecking(errors, symbolTable))//checkeo el tipo de retorno
                    if (cond)
                    {
                        Scope = symbolTable.TopScope.Clone();
                        return true;
                    }
            return false;
        }


        #endregion

        #region	Auxiliar Methods

        protected virtual bool CheckCondition(List<Error> errors, SymbolTable symbolTable)
        {
            //Check Condition
            if (ConditionExp.CheckSemantic(errors, symbolTable))
            {
                if (!(ConditionExp.ReturnType.PrimitiveType is IntegerType))
                {
                    string message = "Expression  cannot be converted to 'int' type";
                    errors.Add(new Error(message, ConditionExp.Line, ConditionExp.CharPositionInLine));
                    ReturnType = TypeExpression.ErrorType;
                }
                else return true;
            }
            return false;
        }
        protected virtual bool CheckInstructions(List<Error> errors, SymbolTable symbolTable)
        {
            return false;
        }
        /// <summary>
        /// este metodo ya se encarga tambien de definir el tipo de retorno de la expresion
        /// </summary>
        protected virtual bool TypeChecking(List<Error> errors, SymbolTable symbolTable)
        {
            //Note: aki todos los tipos son distintos de error, en otro caso no se llamaria a este metodo 
            return false;
        }

        #endregion
    }
}
