﻿using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;

namespace TigertronCompiler.SemanticAnalysis
{
    /// <summary>
    /// This class make and link our decorated AST_Nodes from AST generated by ANTLR
    /// </summary>
    public class ASTFactory : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            if (payload == null)
                return base.Create(payload);
            switch (payload.Type)
            {
                #region	DeclarationNode

                #region	BlockDeclarationNode

                case TigerParser.BLOCK_FUNC_DECL:
                    return new FunctionDeclarationSeqNode(payload);
                case TigerParser.BLOCK_TYPE_DECL:
                    return new TypeDeclarationSeqNode(payload);
                case TigerParser.BLOCK_VAR_DECL:
                    return new VarDeclarationSeqNode(payload);

                #endregion

                #region	AtomicDeclarationNode

                //function declaration
                case TigerParser.FUNCTION_DECLARATION_NODE:
                    return new FunctionDeclarationNode(payload);
                case TigerParser.PROCEDURE_DECLARATION_NODE:
                    return new ProcedureDeclarationNode(payload);

                //variable declaration
                case TigerParser.DEFINED_TYPE_VAR_DEC_NODE:
                    return new DefTypeVarDeclarationNode(payload);
                case TigerParser.INFERENCED_TYPE_VAR_DEC_NODE:
                    return new InfTypeVarDeclarationNode(payload);

                //type declaration
                case TigerParser.ALIAS_TYPE_DEC_NODE:
                    return new AliasDeclarationNode(payload);
                case TigerParser.ARRAY_TYPE_DEC_NODE:
                    return new ArrayDeclarationNode(payload);
                case TigerParser.RECORD_TYPE_DEC_NODE:
                    return new RecordDeclarationNode(payload);

                //type-field
                case TigerParser.FIELD_DECLARATION_NODE:
                    return new FieldNode(payload);

                #endregion

                #endregion

                #region	InstructionNode

                case TigerParser.EXPRESSION_SEQ_INSTR_NODE:
                    return new InstructionsSeqNode(payload);

                case TigerParser.CALL_FUNCTION_NODE:
                    return new FunctionCallNode(payload);

                case TigerParser.LET_INSTRUCTION_NODE:
                    return new LetInstructionNode(payload);

                case TigerParser.IDENTIFIER_NODE:
                    return new IdentifierNode(payload);

                #region	ConstantNode

                case TigerParser.ARRAY_CREATION_NODE:
                    return new ArrayConstantNode(payload);
                case TigerParser.RECORD_CREATION_NODE:
                    return new RecordCostantNode(payload);

                case TigerParser.KW_NIL:
                    return new NilValueNode(payload);
                case TigerParser.STRING_CONSTANT:
                    return new StringConstantNode(payload);
                case TigerParser.INT_CONSTANT:
                    return new IntegerConstantNode(payload);

                #endregion

                #region	AccessInstructionNode

                case TigerParser.SUBSCRIPT_ACCES:
                    return new ArrayAccessNode(payload);
                case TigerParser.FIELD_ACCES:
                    return new RecordAccessNode(payload);

                #endregion

                #region	FlowControl

                case TigerParser.KW_BREAK:
                    return new BreakNode(payload);

                //ConditionalJump
                case TigerParser.IF_THEN_NODE:
                    return new IfThenNode(payload);
                case TigerParser.IF_THEN_ELSE_NODE:
                    return new IfThenElseNode(payload);

                //Loops
                case TigerParser.KW_WHILE:
                    return new WhileLoopNode(payload);
                case TigerParser.KW_FOR:
                    return new ForLoopNode(payload);


                #endregion

                #region	Operations

                #region	UnaryOperations

                case TigerParser.UNARY_MINUS_OP:
                    return new UnaryMinusOperationNode(payload);

                #endregion

                #region	BinaryOperations

                case TigerParser.ASSIGN_OP:
                    return new AssignmentOperationNode(payload);

                #region	ArithmeticalOperations

                case TigerParser.MINUS_OP:
                    return new MinusOperationNode(payload);
                case TigerParser.PLUS_OP:
                    return new PlusOperationNode(payload);
                case TigerParser.MULT_OP:
                    return new MultOperationNode(payload);
                case TigerParser.DIV_OP:
                    return new DivOperationNode(payload);

                #endregion

                #region	LogicalOperations

                case TigerParser.OR_OP:
                    return new OrOperationNode(payload);
                case TigerParser.AND_OP:
                    return new AndOperationNode(payload);

                #endregion

                #region	RelationalOperations

                case TigerParser.LESS_THAN_EQUAL_OP:
                    return new LessEqualThanOperationNode(payload);
                case TigerParser.LESS_THAN_OP:
                    return new LessThanOperationNode(payload);
                case TigerParser.GREATER_THAN_EQUAL_OP:
                    return new GreaterEqualThanOperationNode(payload);
                case TigerParser.GREATER_THAN_OP:
                    return new GreaterThanOperationNode(payload);
                case TigerParser.EQUAL_OP:
                    return new EqualOperationNode(payload);
                case TigerParser.DISTINCT_OP:
                    return new DistinctOperationNode(payload);

                #endregion

                #endregion

                #endregion

                #endregion

                default:
                    return base.Create(payload);
            }
        }
    }
}
