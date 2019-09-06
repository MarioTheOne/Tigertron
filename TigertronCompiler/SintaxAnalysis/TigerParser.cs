// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\Gustavo\\Desktop\\Tiger.g 2012-02-26 18:17:22

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


  using TigertronCompiler.ErrorHandling;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "KW_ARRAY", "KW_BREAK", "KW_DO", "KW_ELSE", "KW_END", "KW_FOR", "KW_FUNCTION", "KW_IF", "KW_IN", "KW_LET", "KW_NIL", "KW_OF", "KW_THEN", "KW_TO", "KW_TYPE", "KW_VAR", "KW_WHILE", "POINT", "COMMA", "COLON", "SEMICOLON", "OPEN_BRACE", "CLOSE_BRACE", "OPEN_BRACKET", "CLOSE_BRACKET", "OPEN_PARENTHESIS", "CLOSE_PARENTHESIS", "ASSIGN_OP", "PLUS_OP", "MINUS_OP", "MULT_OP", "DIV_OP", "AND_OP", "OR_OP", "EQUAL_OP", "DISTINCT_OP", "LESS_THAN_OP", "LESS_THAN_EQUAL_OP", "GREATER_THAN_OP", "GREATER_THAN_EQUAL_OP", "UNARY_MINUS_OP", "EXPRESSION_SEQ_INSTR_NODE", "IDENTIFIER_NODE", "IDENTIFIER_NAME", "CALL_FUNCTION_NODE", "FUNCTION_NAME", "RECORD_CREATION_NODE", "FIELD_ASSIGN", "FIELD_ASSIGN_LIST", "ARRAY_CREATION_NODE", "FIELD_ACCES", "SUBSCRIPT_ACCES", "PARAMETERS_CALL", "IF_THEN_NODE", "IF_THEN_ELSE_NODE", "LET_INSTRUCTION_NODE", "EXPR_SEQ_NODE", "DECLARATION_LIST_NODE", "ALIAS_TYPE_DEC_NODE", "ARRAY_TYPE_DEC_NODE", "RECORD_TYPE_DEC_NODE", "FIELDS_RECORD", "INFERENCED_TYPE_VAR_DEC_NODE", "DEFINED_TYPE_VAR_DEC_NODE", "PROCEDURE_DECLARATION_NODE", "FUNCTION_DECLARATION_NODE", "PARAMETERS_DEC", "FIELD_DECLARATION_NODE", "BLOCK_TYPE_DECL", "BLOCK_VAR_DECL", "BLOCK_FUNC_DECL", "LETTER", "DIGIT", "IDENTIFIER", "WS", "COMMENT", "INT_CONSTANT", "DOUBLE_QUOTE", "ESC_SEQ", "BACK_SLASH", "STRING_CONSTANT"
	};
	public const int EOF=-1;
	public const int KW_ARRAY=4;
	public const int KW_BREAK=5;
	public const int KW_DO=6;
	public const int KW_ELSE=7;
	public const int KW_END=8;
	public const int KW_FOR=9;
	public const int KW_FUNCTION=10;
	public const int KW_IF=11;
	public const int KW_IN=12;
	public const int KW_LET=13;
	public const int KW_NIL=14;
	public const int KW_OF=15;
	public const int KW_THEN=16;
	public const int KW_TO=17;
	public const int KW_TYPE=18;
	public const int KW_VAR=19;
	public const int KW_WHILE=20;
	public const int POINT=21;
	public const int COMMA=22;
	public const int COLON=23;
	public const int SEMICOLON=24;
	public const int OPEN_BRACE=25;
	public const int CLOSE_BRACE=26;
	public const int OPEN_BRACKET=27;
	public const int CLOSE_BRACKET=28;
	public const int OPEN_PARENTHESIS=29;
	public const int CLOSE_PARENTHESIS=30;
	public const int ASSIGN_OP=31;
	public const int PLUS_OP=32;
	public const int MINUS_OP=33;
	public const int MULT_OP=34;
	public const int DIV_OP=35;
	public const int AND_OP=36;
	public const int OR_OP=37;
	public const int EQUAL_OP=38;
	public const int DISTINCT_OP=39;
	public const int LESS_THAN_OP=40;
	public const int LESS_THAN_EQUAL_OP=41;
	public const int GREATER_THAN_OP=42;
	public const int GREATER_THAN_EQUAL_OP=43;
	public const int UNARY_MINUS_OP=44;
	public const int EXPRESSION_SEQ_INSTR_NODE=45;
	public const int IDENTIFIER_NODE=46;
	public const int IDENTIFIER_NAME=47;
	public const int CALL_FUNCTION_NODE=48;
	public const int FUNCTION_NAME=49;
	public const int RECORD_CREATION_NODE=50;
	public const int FIELD_ASSIGN=51;
	public const int FIELD_ASSIGN_LIST=52;
	public const int ARRAY_CREATION_NODE=53;
	public const int FIELD_ACCES=54;
	public const int SUBSCRIPT_ACCES=55;
	public const int PARAMETERS_CALL=56;
	public const int IF_THEN_NODE=57;
	public const int IF_THEN_ELSE_NODE=58;
	public const int LET_INSTRUCTION_NODE=59;
	public const int EXPR_SEQ_NODE=60;
	public const int DECLARATION_LIST_NODE=61;
	public const int ALIAS_TYPE_DEC_NODE=62;
	public const int ARRAY_TYPE_DEC_NODE=63;
	public const int RECORD_TYPE_DEC_NODE=64;
	public const int FIELDS_RECORD=65;
	public const int INFERENCED_TYPE_VAR_DEC_NODE=66;
	public const int DEFINED_TYPE_VAR_DEC_NODE=67;
	public const int PROCEDURE_DECLARATION_NODE=68;
	public const int FUNCTION_DECLARATION_NODE=69;
	public const int PARAMETERS_DEC=70;
	public const int FIELD_DECLARATION_NODE=71;
	public const int BLOCK_TYPE_DECL=72;
	public const int BLOCK_VAR_DECL=73;
	public const int BLOCK_FUNC_DECL=74;
	public const int LETTER=75;
	public const int DIGIT=76;
	public const int IDENTIFIER=77;
	public const int WS=78;
	public const int COMMENT=79;
	public const int INT_CONSTANT=80;
	public const int DOUBLE_QUOTE=81;
	public const int ESC_SEQ=82;
	public const int BACK_SLASH=83;
	public const int STRING_CONSTANT=84;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, true, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				true, false, false, false, false, false, false, false, false, false, 
				false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public TigerParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public TigerParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return TigerParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\Gustavo\\Desktop\\Tiger.g"; } }


	    public List<Error> Errors = new List<Error>();
	    public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
	    {
	        string infoError = base.GetErrorMessage(e, tokenNames);
	        Errors.Add(new Error(infoError, e.Line, e.CharPositionInLine,ErrorKind.SyntaxError));
	        return infoError;
	    }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class tiger_program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tiger_program();
	partial void Leave_tiger_program();

	// $ANTLR start "tiger_program"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:224:1: tiger_program : expression EOF ;
	[GrammarRule("tiger_program")]
	public TigerParser.tiger_program_return tiger_program()
	{
		Enter_tiger_program();
		EnterRule("tiger_program", 1);
		TraceIn("tiger_program", 1);
		TigerParser.tiger_program_return retval = new TigerParser.tiger_program_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken EOF2=null;
		TigerParser.expression_return expression1 = default(TigerParser.expression_return);

		CommonTree EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "tiger_program");
		DebugLocation(224, 18);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:233:2: ( expression EOF )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:233:4: expression EOF
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(233, 4);
			PushFollow(Follow._expression_in_tiger_program1152);
			expression1=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression1.Tree);
			DebugLocation(233, 18);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_tiger_program1154); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tiger_program", 1);
			LeaveRule("tiger_program", 1);
			Leave_tiger_program();
		}
		DebugLocation(233, 18);
		} finally { DebugExitRule(GrammarFileName, "tiger_program"); }
		return retval;

	}
	// $ANTLR end "tiger_program"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:235:1: expression : disjunction_expr ;
	[GrammarRule("expression")]
	private TigerParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 2);
		TraceIn("expression", 2);
		TigerParser.expression_return retval = new TigerParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.disjunction_expr_return disjunction_expr3 = default(TigerParser.disjunction_expr_return);


		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(235, 20);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:236:2: ( disjunction_expr )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:236:4: disjunction_expr
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(236, 4);
			PushFollow(Follow._disjunction_expr_in_expression1165);
			disjunction_expr3=disjunction_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction_expr3.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 2);
			LeaveRule("expression", 2);
			Leave_expression();
		}
		DebugLocation(236, 20);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class disjunction_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_disjunction_expr();
	partial void Leave_disjunction_expr();

	// $ANTLR start "disjunction_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:239:1: disjunction_expr : conjunction_expr ( OR_OP conjunction_expr )* ;
	[GrammarRule("disjunction_expr")]
	private TigerParser.disjunction_expr_return disjunction_expr()
	{
		Enter_disjunction_expr();
		EnterRule("disjunction_expr", 3);
		TraceIn("disjunction_expr", 3);
		TigerParser.disjunction_expr_return retval = new TigerParser.disjunction_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken OR_OP5=null;
		TigerParser.conjunction_expr_return conjunction_expr4 = default(TigerParser.conjunction_expr_return);
		TigerParser.conjunction_expr_return conjunction_expr6 = default(TigerParser.conjunction_expr_return);

		CommonTree OR_OP5_tree=null;

		try { DebugEnterRule(GrammarFileName, "disjunction_expr");
		DebugLocation(239, 47);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:240:2: ( conjunction_expr ( OR_OP conjunction_expr )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:240:4: conjunction_expr ( OR_OP conjunction_expr )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(240, 4);
			PushFollow(Follow._conjunction_expr_in_disjunction_expr1178);
			conjunction_expr4=conjunction_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conjunction_expr4.Tree);
			DebugLocation(240, 21);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:240:21: ( OR_OP conjunction_expr )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==OR_OP))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:240:22: OR_OP conjunction_expr
					{
					DebugLocation(240, 27);
					OR_OP5=(IToken)Match(input,OR_OP,Follow._OR_OP_in_disjunction_expr1181); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR_OP5_tree = (CommonTree)adaptor.Create(OR_OP5);
					root_0 = (CommonTree)adaptor.BecomeRoot(OR_OP5_tree, root_0);
					}
					DebugLocation(240, 29);
					PushFollow(Follow._conjunction_expr_in_disjunction_expr1184);
					conjunction_expr6=conjunction_expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conjunction_expr6.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("disjunction_expr", 3);
			LeaveRule("disjunction_expr", 3);
			Leave_disjunction_expr();
		}
		DebugLocation(240, 47);
		} finally { DebugExitRule(GrammarFileName, "disjunction_expr"); }
		return retval;

	}
	// $ANTLR end "disjunction_expr"

	public class conjunction_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conjunction_expr();
	partial void Leave_conjunction_expr();

	// $ANTLR start "conjunction_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:242:1: conjunction_expr : relational_expr ( AND_OP relational_expr )* ;
	[GrammarRule("conjunction_expr")]
	private TigerParser.conjunction_expr_return conjunction_expr()
	{
		Enter_conjunction_expr();
		EnterRule("conjunction_expr", 4);
		TraceIn("conjunction_expr", 4);
		TigerParser.conjunction_expr_return retval = new TigerParser.conjunction_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken AND_OP8=null;
		TigerParser.relational_expr_return relational_expr7 = default(TigerParser.relational_expr_return);
		TigerParser.relational_expr_return relational_expr9 = default(TigerParser.relational_expr_return);

		CommonTree AND_OP8_tree=null;

		try { DebugEnterRule(GrammarFileName, "conjunction_expr");
		DebugLocation(242, 46);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:243:2: ( relational_expr ( AND_OP relational_expr )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:243:4: relational_expr ( AND_OP relational_expr )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(243, 4);
			PushFollow(Follow._relational_expr_in_conjunction_expr1197);
			relational_expr7=relational_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relational_expr7.Tree);
			DebugLocation(243, 20);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:243:20: ( AND_OP relational_expr )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==AND_OP))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:243:21: AND_OP relational_expr
					{
					DebugLocation(243, 27);
					AND_OP8=(IToken)Match(input,AND_OP,Follow._AND_OP_in_conjunction_expr1200); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND_OP8_tree = (CommonTree)adaptor.Create(AND_OP8);
					root_0 = (CommonTree)adaptor.BecomeRoot(AND_OP8_tree, root_0);
					}
					DebugLocation(243, 29);
					PushFollow(Follow._relational_expr_in_conjunction_expr1203);
					relational_expr9=relational_expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relational_expr9.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conjunction_expr", 4);
			LeaveRule("conjunction_expr", 4);
			Leave_conjunction_expr();
		}
		DebugLocation(243, 46);
		} finally { DebugExitRule(GrammarFileName, "conjunction_expr"); }
		return retval;

	}
	// $ANTLR end "conjunction_expr"

	public class relational_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relational_expr();
	partial void Leave_relational_expr();

	// $ANTLR start "relational_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:245:1: relational_expr : arithmetical_expr ( relational_operator arithmetical_expr )? ;
	[GrammarRule("relational_expr")]
	private TigerParser.relational_expr_return relational_expr()
	{
		Enter_relational_expr();
		EnterRule("relational_expr", 5);
		TraceIn("relational_expr", 5);
		TigerParser.relational_expr_return retval = new TigerParser.relational_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.arithmetical_expr_return arithmetical_expr10 = default(TigerParser.arithmetical_expr_return);
		TigerParser.relational_operator_return relational_operator11 = default(TigerParser.relational_operator_return);
		TigerParser.arithmetical_expr_return arithmetical_expr12 = default(TigerParser.arithmetical_expr_return);


		try { DebugEnterRule(GrammarFileName, "relational_expr");
		DebugLocation(245, 63);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:246:2: ( arithmetical_expr ( relational_operator arithmetical_expr )? )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:246:4: arithmetical_expr ( relational_operator arithmetical_expr )?
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(246, 4);
			PushFollow(Follow._arithmetical_expr_in_relational_expr1216);
			arithmetical_expr10=arithmetical_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arithmetical_expr10.Tree);
			DebugLocation(246, 22);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:246:22: ( relational_operator arithmetical_expr )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case EQUAL_OP:
				{
				alt3=1;
				}
				break;
			case DISTINCT_OP:
				{
				alt3=1;
				}
				break;
			case LESS_THAN_OP:
				{
				alt3=1;
				}
				break;
			case LESS_THAN_EQUAL_OP:
				{
				alt3=1;
				}
				break;
			case GREATER_THAN_OP:
				{
				alt3=1;
				}
				break;
			case GREATER_THAN_EQUAL_OP:
				{
				alt3=1;
				}
				break;
			}

			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:246:23: relational_operator arithmetical_expr
				{
				DebugLocation(246, 42);
				PushFollow(Follow._relational_operator_in_relational_expr1219);
				relational_operator11=relational_operator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(relational_operator11.Tree, root_0);
				DebugLocation(246, 44);
				PushFollow(Follow._arithmetical_expr_in_relational_expr1222);
				arithmetical_expr12=arithmetical_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arithmetical_expr12.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relational_expr", 5);
			LeaveRule("relational_expr", 5);
			Leave_relational_expr();
		}
		DebugLocation(246, 63);
		} finally { DebugExitRule(GrammarFileName, "relational_expr"); }
		return retval;

	}
	// $ANTLR end "relational_expr"

	public class arithmetical_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arithmetical_expr();
	partial void Leave_arithmetical_expr();

	// $ANTLR start "arithmetical_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:248:1: arithmetical_expr : term ( add_operator term )* ;
	[GrammarRule("arithmetical_expr")]
	private TigerParser.arithmetical_expr_return arithmetical_expr()
	{
		Enter_arithmetical_expr();
		EnterRule("arithmetical_expr", 6);
		TraceIn("arithmetical_expr", 6);
		TigerParser.arithmetical_expr_return retval = new TigerParser.arithmetical_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.term_return term13 = default(TigerParser.term_return);
		TigerParser.add_operator_return add_operator14 = default(TigerParser.add_operator_return);
		TigerParser.term_return term15 = default(TigerParser.term_return);


		try { DebugEnterRule(GrammarFileName, "arithmetical_expr");
		DebugLocation(248, 30);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:249:2: ( term ( add_operator term )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:249:4: term ( add_operator term )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(249, 4);
			PushFollow(Follow._term_in_arithmetical_expr1235);
			term13=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term13.Tree);
			DebugLocation(249, 9);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:249:9: ( add_operator term )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==PLUS_OP))
				{
					alt4=1;
				}
				else if ((LA4_0==MINUS_OP))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:249:10: add_operator term
					{
					DebugLocation(249, 22);
					PushFollow(Follow._add_operator_in_arithmetical_expr1238);
					add_operator14=add_operator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(add_operator14.Tree, root_0);
					DebugLocation(249, 24);
					PushFollow(Follow._term_in_arithmetical_expr1241);
					term15=term();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term15.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arithmetical_expr", 6);
			LeaveRule("arithmetical_expr", 6);
			Leave_arithmetical_expr();
		}
		DebugLocation(249, 30);
		} finally { DebugExitRule(GrammarFileName, "arithmetical_expr"); }
		return retval;

	}
	// $ANTLR end "arithmetical_expr"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:251:1: term : factor ( product_operator factor )* ;
	[GrammarRule("term")]
	private TigerParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 7);
		TraceIn("term", 7);
		TigerParser.term_return retval = new TigerParser.term_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.factor_return factor16 = default(TigerParser.factor_return);
		TigerParser.product_operator_return product_operator17 = default(TigerParser.product_operator_return);
		TigerParser.factor_return factor18 = default(TigerParser.factor_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(251, 38);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:252:2: ( factor ( product_operator factor )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:252:4: factor ( product_operator factor )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(252, 4);
			PushFollow(Follow._factor_in_term1255);
			factor16=factor();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor16.Tree);
			DebugLocation(252, 11);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:252:11: ( product_operator factor )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==MULT_OP))
				{
					alt5=1;
				}
				else if ((LA5_0==DIV_OP))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:252:12: product_operator factor
					{
					DebugLocation(252, 28);
					PushFollow(Follow._product_operator_in_term1258);
					product_operator17=product_operator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(product_operator17.Tree, root_0);
					DebugLocation(252, 30);
					PushFollow(Follow._factor_in_term1261);
					factor18=factor();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, factor18.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 7);
			LeaveRule("term", 7);
			Leave_term();
		}
		DebugLocation(252, 38);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class factor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_factor();
	partial void Leave_factor();

	// $ANTLR start "factor"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:254:1: factor : ( constant_type | ( IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF )=> array_creation | flow_control_expr | let_in_expr | MINUS_OP factor -> ^( UNARY_MINUS_OP factor ) | high_acces_assign_expr );
	[GrammarRule("factor")]
	private TigerParser.factor_return factor()
	{
		Enter_factor();
		EnterRule("factor", 8);
		TraceIn("factor", 8);
		TigerParser.factor_return retval = new TigerParser.factor_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken MINUS_OP23=null;
		TigerParser.constant_type_return constant_type19 = default(TigerParser.constant_type_return);
		TigerParser.array_creation_return array_creation20 = default(TigerParser.array_creation_return);
		TigerParser.flow_control_expr_return flow_control_expr21 = default(TigerParser.flow_control_expr_return);
		TigerParser.let_in_expr_return let_in_expr22 = default(TigerParser.let_in_expr_return);
		TigerParser.factor_return factor24 = default(TigerParser.factor_return);
		TigerParser.high_acces_assign_expr_return high_acces_assign_expr25 = default(TigerParser.high_acces_assign_expr_return);

		CommonTree MINUS_OP23_tree=null;
		RewriteRuleITokenStream stream_MINUS_OP=new RewriteRuleITokenStream(adaptor,"token MINUS_OP");
		RewriteRuleSubtreeStream stream_factor=new RewriteRuleSubtreeStream(adaptor,"rule factor");
		try { DebugEnterRule(GrammarFileName, "factor");
		DebugLocation(254, 1);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:254:8: ( constant_type | ( IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF )=> array_creation | flow_control_expr | let_in_expr | MINUS_OP factor -> ^( UNARY_MINUS_OP factor ) | high_acces_assign_expr )
			int alt6=6;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			try
			{
				alt6 = dfa6.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:254:10: constant_type
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(254, 10);
				PushFollow(Follow._constant_type_in_factor1273);
				constant_type19=constant_type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constant_type19.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:255:3: ( IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF )=> array_creation
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(255, 67);
				PushFollow(Follow._array_creation_in_factor1295);
				array_creation20=array_creation();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, array_creation20.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:256:4: flow_control_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(256, 4);
				PushFollow(Follow._flow_control_expr_in_factor1300);
				flow_control_expr21=flow_control_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, flow_control_expr21.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:257:4: let_in_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(257, 4);
				PushFollow(Follow._let_in_expr_in_factor1305);
				let_in_expr22=let_in_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, let_in_expr22.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:258:4: MINUS_OP factor
				{
				DebugLocation(258, 4);
				MINUS_OP23=(IToken)Match(input,MINUS_OP,Follow._MINUS_OP_in_factor1310); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS_OP.Add(MINUS_OP23);

				DebugLocation(258, 14);
				PushFollow(Follow._factor_in_factor1313);
				factor24=factor();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_factor.Add(factor24.Tree);


				{
				// AST REWRITE
				// elements: factor
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 258:26: -> ^( UNARY_MINUS_OP factor )
				{
					DebugLocation(258, 34);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:258:34: ^( UNARY_MINUS_OP factor )
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(258, 36);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(UNARY_MINUS_OP, "UNARY_MINUS_OP"), root_1);

					DebugLocation(258, 53);
					adaptor.AddChild(root_1, stream_factor.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:259:4: high_acces_assign_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(259, 4);
				PushFollow(Follow._high_acces_assign_expr_in_factor1338);
				high_acces_assign_expr25=high_acces_assign_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, high_acces_assign_expr25.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("factor", 8);
			LeaveRule("factor", 8);
			Leave_factor();
		}
		DebugLocation(260, 1);
		} finally { DebugExitRule(GrammarFileName, "factor"); }
		return retval;

	}
	// $ANTLR end "factor"

	public class high_acces_assign_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_high_acces_assign_expr();
	partial void Leave_high_acces_assign_expr();

	// $ANTLR start "high_acces_assign_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:263:1: high_acces_assign_expr : assignable_expr ( assign_expr )? ;
	[GrammarRule("high_acces_assign_expr")]
	private TigerParser.high_acces_assign_expr_return high_acces_assign_expr()
	{
		Enter_high_acces_assign_expr();
		EnterRule("high_acces_assign_expr", 9);
		TraceIn("high_acces_assign_expr", 9);
		TigerParser.high_acces_assign_expr_return retval = new TigerParser.high_acces_assign_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.assignable_expr_return assignable_expr26 = default(TigerParser.assignable_expr_return);
		TigerParser.assign_expr_return assign_expr27 = default(TigerParser.assign_expr_return);


		try { DebugEnterRule(GrammarFileName, "high_acces_assign_expr");
		DebugLocation(263, 38);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:264:2: ( assignable_expr ( assign_expr )? )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:264:4: assignable_expr ( assign_expr )?
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(264, 4);
			PushFollow(Follow._assignable_expr_in_high_acces_assign_expr1351);
			assignable_expr26=assignable_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignable_expr26.Tree);
			DebugLocation(264, 24);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:264:24: ( assign_expr )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==ASSIGN_OP))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:264:25: assign_expr
				{
				DebugLocation(264, 36);
				PushFollow(Follow._assign_expr_in_high_acces_assign_expr1358);
				assign_expr27=assign_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(assign_expr27.Tree, root_0);

				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("high_acces_assign_expr", 9);
			LeaveRule("high_acces_assign_expr", 9);
			Leave_high_acces_assign_expr();
		}
		DebugLocation(264, 38);
		} finally { DebugExitRule(GrammarFileName, "high_acces_assign_expr"); }
		return retval;

	}
	// $ANTLR end "high_acces_assign_expr"

	public class assignable_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignable_expr();
	partial void Leave_assignable_expr();

	// $ANTLR start "assignable_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:266:1: assignable_expr : accessible_expr ( high_acces )* ;
	[GrammarRule("assignable_expr")]
	private TigerParser.assignable_expr_return assignable_expr()
	{
		Enter_assignable_expr();
		EnterRule("assignable_expr", 10);
		TraceIn("assignable_expr", 10);
		TigerParser.assignable_expr_return retval = new TigerParser.assignable_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.accessible_expr_return accessible_expr28 = default(TigerParser.accessible_expr_return);
		TigerParser.high_acces_return high_acces29 = default(TigerParser.high_acces_return);


		try { DebugEnterRule(GrammarFileName, "assignable_expr");
		DebugLocation(266, 34);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:266:17: ( accessible_expr ( high_acces )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:267:2: accessible_expr ( high_acces )*
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(267, 2);
			PushFollow(Follow._accessible_expr_in_assignable_expr1370);
			accessible_expr28=accessible_expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, accessible_expr28.Tree);
			DebugLocation(267, 21);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:267:21: ( high_acces )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==POINT||LA8_0==OPEN_BRACKET))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:267:22: high_acces
					{
					DebugLocation(267, 32);
					PushFollow(Follow._high_acces_in_assignable_expr1376);
					high_acces29=high_acces();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (CommonTree)adaptor.BecomeRoot(high_acces29.Tree, root_0);

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignable_expr", 10);
			LeaveRule("assignable_expr", 10);
			Leave_assignable_expr();
		}
		DebugLocation(267, 34);
		} finally { DebugExitRule(GrammarFileName, "assignable_expr"); }
		return retval;

	}
	// $ANTLR end "assignable_expr"

	public class accessible_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_accessible_expr();
	partial void Leave_accessible_expr();

	// $ANTLR start "accessible_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:269:1: accessible_expr : ( ( IDENTIFIER OPEN_BRACE )=> record_literal_init | ( IDENTIFIER OPEN_PARENTHESIS )=> call_function_expr | expr_seq_instr | lvalue );
	[GrammarRule("accessible_expr")]
	private TigerParser.accessible_expr_return accessible_expr()
	{
		Enter_accessible_expr();
		EnterRule("accessible_expr", 11);
		TraceIn("accessible_expr", 11);
		TigerParser.accessible_expr_return retval = new TigerParser.accessible_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.record_literal_init_return record_literal_init30 = default(TigerParser.record_literal_init_return);
		TigerParser.call_function_expr_return call_function_expr31 = default(TigerParser.call_function_expr_return);
		TigerParser.expr_seq_instr_return expr_seq_instr32 = default(TigerParser.expr_seq_instr_return);
		TigerParser.lvalue_return lvalue33 = default(TigerParser.lvalue_return);


		try { DebugEnterRule(GrammarFileName, "accessible_expr");
		DebugLocation(269, 10);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:270:2: ( ( IDENTIFIER OPEN_BRACE )=> record_literal_init | ( IDENTIFIER OPEN_PARENTHESIS )=> call_function_expr | expr_seq_instr | lvalue )
			int alt9=4;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==IDENTIFIER))
			{
				int LA9_1 = input.LA(2);

				if ((LA9_1==OPEN_BRACE) && (EvaluatePredicate(synpred2_Tiger_fragment)))
				{
					alt9=1;
				}
				else if ((LA9_1==OPEN_PARENTHESIS) && (EvaluatePredicate(synpred3_Tiger_fragment)))
				{
					alt9=2;
				}
				else if ((LA9_1==EOF||(LA9_1>=KW_DO && LA9_1<=KW_END)||LA9_1==KW_FUNCTION||LA9_1==KW_IN||(LA9_1>=KW_THEN && LA9_1<=KW_VAR)||(LA9_1>=POINT && LA9_1<=COMMA)||LA9_1==SEMICOLON||(LA9_1>=CLOSE_BRACE && LA9_1<=CLOSE_BRACKET)||(LA9_1>=CLOSE_PARENTHESIS && LA9_1<=GREATER_THAN_EQUAL_OP)))
				{
					alt9=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 9, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA9_0==OPEN_PARENTHESIS))
			{
				alt9=3;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:270:5: ( IDENTIFIER OPEN_BRACE )=> record_literal_init
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(270, 36);
				PushFollow(Follow._record_literal_init_in_accessible_expr1401);
				record_literal_init30=record_literal_init();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, record_literal_init30.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:271:5: ( IDENTIFIER OPEN_PARENTHESIS )=> call_function_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(271, 44);
				PushFollow(Follow._call_function_expr_in_accessible_expr1422);
				call_function_expr31=call_function_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call_function_expr31.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:272:5: expr_seq_instr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(272, 5);
				PushFollow(Follow._expr_seq_instr_in_accessible_expr1429);
				expr_seq_instr32=expr_seq_instr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_seq_instr32.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:273:5: lvalue
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(273, 5);
				PushFollow(Follow._lvalue_in_accessible_expr1435);
				lvalue33=lvalue();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lvalue33.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("accessible_expr", 11);
			LeaveRule("accessible_expr", 11);
			Leave_accessible_expr();
		}
		DebugLocation(273, 10);
		} finally { DebugExitRule(GrammarFileName, "accessible_expr"); }
		return retval;

	}
	// $ANTLR end "accessible_expr"

	public class lvalue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:276:1: lvalue : name= IDENTIFIER -> ^( IDENTIFIER_NODE $name) ;
	[GrammarRule("lvalue")]
	private TigerParser.lvalue_return lvalue()
	{
		Enter_lvalue();
		EnterRule("lvalue", 12);
		TraceIn("lvalue", 12);
		TigerParser.lvalue_return retval = new TigerParser.lvalue_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name=null;

		CommonTree name_tree=null;
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");

		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(276, 29);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:277:2: (name= IDENTIFIER -> ^( IDENTIFIER_NODE $name) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:277:4: name= IDENTIFIER
			{
			DebugLocation(277, 9);
			name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_lvalue1449); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name);



			{
			// AST REWRITE
			// elements: name
			// token labels: name
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 278:2: -> ^( IDENTIFIER_NODE $name)
			{
				DebugLocation(278, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:278:5: ^( IDENTIFIER_NODE $name)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(278, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IDENTIFIER_NODE, "IDENTIFIER_NODE"), root_1);

				DebugLocation(278, 24);
				adaptor.AddChild(root_1, stream_name.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("lvalue", 12);
			LeaveRule("lvalue", 12);
			Leave_lvalue();
		}
		DebugLocation(278, 29);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return retval;

	}
	// $ANTLR end "lvalue"

	public class constant_type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_constant_type();
	partial void Leave_constant_type();

	// $ANTLR start "constant_type"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:280:1: constant_type : ( INT_CONSTANT | STRING_CONSTANT | KW_NIL );
	[GrammarRule("constant_type")]
	private TigerParser.constant_type_return constant_type()
	{
		Enter_constant_type();
		EnterRule("constant_type", 13);
		TraceIn("constant_type", 13);
		TigerParser.constant_type_return retval = new TigerParser.constant_type_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken INT_CONSTANT34=null;
		IToken STRING_CONSTANT35=null;
		IToken KW_NIL36=null;

		CommonTree INT_CONSTANT34_tree=null;
		CommonTree STRING_CONSTANT35_tree=null;
		CommonTree KW_NIL36_tree=null;

		try { DebugEnterRule(GrammarFileName, "constant_type");
		DebugLocation(280, 10);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:281:2: ( INT_CONSTANT | STRING_CONSTANT | KW_NIL )
			int alt10=3;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			switch (input.LA(1))
			{
			case INT_CONSTANT:
				{
				alt10=1;
				}
				break;
			case STRING_CONSTANT:
				{
				alt10=2;
				}
				break;
			case KW_NIL:
				{
				alt10=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:281:4: INT_CONSTANT
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(281, 16);
				INT_CONSTANT34=(IToken)Match(input,INT_CONSTANT,Follow._INT_CONSTANT_in_constant_type1470); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				INT_CONSTANT34_tree = (CommonTree)adaptor.Create(INT_CONSTANT34);
				root_0 = (CommonTree)adaptor.BecomeRoot(INT_CONSTANT34_tree, root_0);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:282:4: STRING_CONSTANT
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(282, 19);
				STRING_CONSTANT35=(IToken)Match(input,STRING_CONSTANT,Follow._STRING_CONSTANT_in_constant_type1476); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				STRING_CONSTANT35_tree = (CommonTree)adaptor.Create(STRING_CONSTANT35);
				root_0 = (CommonTree)adaptor.BecomeRoot(STRING_CONSTANT35_tree, root_0);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:283:4: KW_NIL
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(283, 10);
				KW_NIL36=(IToken)Match(input,KW_NIL,Follow._KW_NIL_in_constant_type1482); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				KW_NIL36_tree = (CommonTree)adaptor.Create(KW_NIL36);
				root_0 = (CommonTree)adaptor.BecomeRoot(KW_NIL36_tree, root_0);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("constant_type", 13);
			LeaveRule("constant_type", 13);
			Leave_constant_type();
		}
		DebugLocation(283, 10);
		} finally { DebugExitRule(GrammarFileName, "constant_type"); }
		return retval;

	}
	// $ANTLR end "constant_type"

	public class expr_seq_instr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_seq_instr();
	partial void Leave_expr_seq_instr();

	// $ANTLR start "expr_seq_instr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:285:1: expr_seq_instr : OPEN_PARENTHESIS ( expr_seq )? CLOSE_PARENTHESIS -> ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) ;
	[GrammarRule("expr_seq_instr")]
	private TigerParser.expr_seq_instr_return expr_seq_instr()
	{
		Enter_expr_seq_instr();
		EnterRule("expr_seq_instr", 14);
		TraceIn("expr_seq_instr", 14);
		TigerParser.expr_seq_instr_return retval = new TigerParser.expr_seq_instr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken OPEN_PARENTHESIS37=null;
		IToken CLOSE_PARENTHESIS39=null;
		TigerParser.expr_seq_return expr_seq38 = default(TigerParser.expr_seq_return);

		CommonTree OPEN_PARENTHESIS37_tree=null;
		CommonTree CLOSE_PARENTHESIS39_tree=null;
		RewriteRuleITokenStream stream_OPEN_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token OPEN_PARENTHESIS");
		RewriteRuleITokenStream stream_CLOSE_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token CLOSE_PARENTHESIS");
		RewriteRuleSubtreeStream stream_expr_seq=new RewriteRuleSubtreeStream(adaptor,"rule expr_seq");
		try { DebugEnterRule(GrammarFileName, "expr_seq_instr");
		DebugLocation(285, 45);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:286:2: ( OPEN_PARENTHESIS ( expr_seq )? CLOSE_PARENTHESIS -> ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:286:3: OPEN_PARENTHESIS ( expr_seq )? CLOSE_PARENTHESIS
			{
			DebugLocation(286, 3);
			OPEN_PARENTHESIS37=(IToken)Match(input,OPEN_PARENTHESIS,Follow._OPEN_PARENTHESIS_in_expr_seq_instr1492); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_PARENTHESIS.Add(OPEN_PARENTHESIS37);

			DebugLocation(286, 21);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:286:21: ( expr_seq )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==KW_BREAK||LA11_0==KW_FOR||LA11_0==KW_IF||(LA11_0>=KW_LET && LA11_0<=KW_NIL)||LA11_0==KW_WHILE||LA11_0==OPEN_PARENTHESIS||LA11_0==MINUS_OP||LA11_0==IDENTIFIER||LA11_0==INT_CONSTANT||LA11_0==STRING_CONSTANT))
			{
				alt11=1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:286:21: expr_seq
				{
				DebugLocation(286, 21);
				PushFollow(Follow._expr_seq_in_expr_seq_instr1495);
				expr_seq38=expr_seq();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_seq.Add(expr_seq38.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(11); }

			DebugLocation(286, 32);
			CLOSE_PARENTHESIS39=(IToken)Match(input,CLOSE_PARENTHESIS,Follow._CLOSE_PARENTHESIS_in_expr_seq_instr1499); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_PARENTHESIS.Add(CLOSE_PARENTHESIS39);



			{
			// AST REWRITE
			// elements: expr_seq
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 287:2: -> ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? )
			{
				DebugLocation(287, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:287:5: ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(287, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION_SEQ_INSTR_NODE, "EXPRESSION_SEQ_INSTR_NODE"), root_1);

				DebugLocation(287, 36);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:287:36: ( expr_seq )?
				if ( stream_expr_seq.HasNext )
				{
					DebugLocation(287, 36);
					adaptor.AddChild(root_1, stream_expr_seq.NextTree());

				}
				stream_expr_seq.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_seq_instr", 14);
			LeaveRule("expr_seq_instr", 14);
			Leave_expr_seq_instr();
		}
		DebugLocation(287, 45);
		} finally { DebugExitRule(GrammarFileName, "expr_seq_instr"); }
		return retval;

	}
	// $ANTLR end "expr_seq_instr"

	public class relational_operator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relational_operator();
	partial void Leave_relational_operator();

	// $ANTLR start "relational_operator"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:293:1: relational_operator : ( ( EQUAL_OP ) | ( DISTINCT_OP ) | ( LESS_THAN_OP ) | ( LESS_THAN_EQUAL_OP ) | ( GREATER_THAN_OP ) | ( GREATER_THAN_EQUAL_OP ) );
	[GrammarRule("relational_operator")]
	private TigerParser.relational_operator_return relational_operator()
	{
		Enter_relational_operator();
		EnterRule("relational_operator", 15);
		TraceIn("relational_operator", 15);
		TigerParser.relational_operator_return retval = new TigerParser.relational_operator_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken EQUAL_OP40=null;
		IToken DISTINCT_OP41=null;
		IToken LESS_THAN_OP42=null;
		IToken LESS_THAN_EQUAL_OP43=null;
		IToken GREATER_THAN_OP44=null;
		IToken GREATER_THAN_EQUAL_OP45=null;

		CommonTree EQUAL_OP40_tree=null;
		CommonTree DISTINCT_OP41_tree=null;
		CommonTree LESS_THAN_OP42_tree=null;
		CommonTree LESS_THAN_EQUAL_OP43_tree=null;
		CommonTree GREATER_THAN_OP44_tree=null;
		CommonTree GREATER_THAN_EQUAL_OP45_tree=null;

		try { DebugEnterRule(GrammarFileName, "relational_operator");
		DebugLocation(293, 115);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:2: ( ( EQUAL_OP ) | ( DISTINCT_OP ) | ( LESS_THAN_OP ) | ( LESS_THAN_EQUAL_OP ) | ( GREATER_THAN_OP ) | ( GREATER_THAN_EQUAL_OP ) )
			int alt12=6;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case EQUAL_OP:
				{
				alt12=1;
				}
				break;
			case DISTINCT_OP:
				{
				alt12=2;
				}
				break;
			case LESS_THAN_OP:
				{
				alt12=3;
				}
				break;
			case LESS_THAN_EQUAL_OP:
				{
				alt12=4;
				}
				break;
			case GREATER_THAN_OP:
				{
				alt12=5;
				}
				break;
			case GREATER_THAN_EQUAL_OP:
				{
				alt12=6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:4: ( EQUAL_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:4: ( EQUAL_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:5: EQUAL_OP
				{
				DebugLocation(294, 5);
				EQUAL_OP40=(IToken)Match(input,EQUAL_OP,Follow._EQUAL_OP_in_relational_operator1529); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				EQUAL_OP40_tree = (CommonTree)adaptor.Create(EQUAL_OP40);
				adaptor.AddChild(root_0, EQUAL_OP40_tree);
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:17: ( DISTINCT_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 17);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:17: ( DISTINCT_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:18: DISTINCT_OP
				{
				DebugLocation(294, 18);
				DISTINCT_OP41=(IToken)Match(input,DISTINCT_OP,Follow._DISTINCT_OP_in_relational_operator1535); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				DISTINCT_OP41_tree = (CommonTree)adaptor.Create(DISTINCT_OP41);
				adaptor.AddChild(root_0, DISTINCT_OP41_tree);
				}

				}


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:33: ( LESS_THAN_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 33);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:33: ( LESS_THAN_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:34: LESS_THAN_OP
				{
				DebugLocation(294, 34);
				LESS_THAN_OP42=(IToken)Match(input,LESS_THAN_OP,Follow._LESS_THAN_OP_in_relational_operator1541); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				LESS_THAN_OP42_tree = (CommonTree)adaptor.Create(LESS_THAN_OP42);
				adaptor.AddChild(root_0, LESS_THAN_OP42_tree);
				}

				}


				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:50: ( LESS_THAN_EQUAL_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 50);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:50: ( LESS_THAN_EQUAL_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:51: LESS_THAN_EQUAL_OP
				{
				DebugLocation(294, 51);
				LESS_THAN_EQUAL_OP43=(IToken)Match(input,LESS_THAN_EQUAL_OP,Follow._LESS_THAN_EQUAL_OP_in_relational_operator1547); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				LESS_THAN_EQUAL_OP43_tree = (CommonTree)adaptor.Create(LESS_THAN_EQUAL_OP43);
				adaptor.AddChild(root_0, LESS_THAN_EQUAL_OP43_tree);
				}

				}


				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:73: ( GREATER_THAN_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 73);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:73: ( GREATER_THAN_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:74: GREATER_THAN_OP
				{
				DebugLocation(294, 74);
				GREATER_THAN_OP44=(IToken)Match(input,GREATER_THAN_OP,Follow._GREATER_THAN_OP_in_relational_operator1553); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				GREATER_THAN_OP44_tree = (CommonTree)adaptor.Create(GREATER_THAN_OP44);
				adaptor.AddChild(root_0, GREATER_THAN_OP44_tree);
				}

				}


				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:93: ( GREATER_THAN_EQUAL_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(294, 93);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:93: ( GREATER_THAN_EQUAL_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:294:94: GREATER_THAN_EQUAL_OP
				{
				DebugLocation(294, 94);
				GREATER_THAN_EQUAL_OP45=(IToken)Match(input,GREATER_THAN_EQUAL_OP,Follow._GREATER_THAN_EQUAL_OP_in_relational_operator1559); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				GREATER_THAN_EQUAL_OP45_tree = (CommonTree)adaptor.Create(GREATER_THAN_EQUAL_OP45);
				adaptor.AddChild(root_0, GREATER_THAN_EQUAL_OP45_tree);
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relational_operator", 15);
			LeaveRule("relational_operator", 15);
			Leave_relational_operator();
		}
		DebugLocation(294, 115);
		} finally { DebugExitRule(GrammarFileName, "relational_operator"); }
		return retval;

	}
	// $ANTLR end "relational_operator"

	public class add_operator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add_operator();
	partial void Leave_add_operator();

	// $ANTLR start "add_operator"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:296:1: add_operator : ( ( PLUS_OP ) | ( MINUS_OP ) );
	[GrammarRule("add_operator")]
	private TigerParser.add_operator_return add_operator()
	{
		Enter_add_operator();
		EnterRule("add_operator", 16);
		TraceIn("add_operator", 16);
		TigerParser.add_operator_return retval = new TigerParser.add_operator_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken PLUS_OP46=null;
		IToken MINUS_OP47=null;

		CommonTree PLUS_OP46_tree=null;
		CommonTree MINUS_OP47_tree=null;

		try { DebugEnterRule(GrammarFileName, "add_operator");
		DebugLocation(296, 25);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:2: ( ( PLUS_OP ) | ( MINUS_OP ) )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==PLUS_OP))
			{
				alt13=1;
			}
			else if ((LA13_0==MINUS_OP))
			{
				alt13=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:4: ( PLUS_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(297, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:4: ( PLUS_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:5: PLUS_OP
				{
				DebugLocation(297, 5);
				PLUS_OP46=(IToken)Match(input,PLUS_OP,Follow._PLUS_OP_in_add_operator1572); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				PLUS_OP46_tree = (CommonTree)adaptor.Create(PLUS_OP46);
				adaptor.AddChild(root_0, PLUS_OP46_tree);
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:16: ( MINUS_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(297, 16);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:16: ( MINUS_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:297:17: MINUS_OP
				{
				DebugLocation(297, 17);
				MINUS_OP47=(IToken)Match(input,MINUS_OP,Follow._MINUS_OP_in_add_operator1578); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MINUS_OP47_tree = (CommonTree)adaptor.Create(MINUS_OP47);
				adaptor.AddChild(root_0, MINUS_OP47_tree);
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add_operator", 16);
			LeaveRule("add_operator", 16);
			Leave_add_operator();
		}
		DebugLocation(297, 25);
		} finally { DebugExitRule(GrammarFileName, "add_operator"); }
		return retval;

	}
	// $ANTLR end "add_operator"

	public class product_operator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_product_operator();
	partial void Leave_product_operator();

	// $ANTLR start "product_operator"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:299:1: product_operator : ( ( MULT_OP ) | ( DIV_OP ) );
	[GrammarRule("product_operator")]
	private TigerParser.product_operator_return product_operator()
	{
		Enter_product_operator();
		EnterRule("product_operator", 17);
		TraceIn("product_operator", 17);
		TigerParser.product_operator_return retval = new TigerParser.product_operator_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken MULT_OP48=null;
		IToken DIV_OP49=null;

		CommonTree MULT_OP48_tree=null;
		CommonTree DIV_OP49_tree=null;

		try { DebugEnterRule(GrammarFileName, "product_operator");
		DebugLocation(299, 23);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:2: ( ( MULT_OP ) | ( DIV_OP ) )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==MULT_OP))
			{
				alt14=1;
			}
			else if ((LA14_0==DIV_OP))
			{
				alt14=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:4: ( MULT_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(300, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:4: ( MULT_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:5: MULT_OP
				{
				DebugLocation(300, 5);
				MULT_OP48=(IToken)Match(input,MULT_OP,Follow._MULT_OP_in_product_operator1589); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MULT_OP48_tree = (CommonTree)adaptor.Create(MULT_OP48);
				adaptor.AddChild(root_0, MULT_OP48_tree);
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:16: ( DIV_OP )
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(300, 16);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:16: ( DIV_OP )
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:300:17: DIV_OP
				{
				DebugLocation(300, 17);
				DIV_OP49=(IToken)Match(input,DIV_OP,Follow._DIV_OP_in_product_operator1595); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				DIV_OP49_tree = (CommonTree)adaptor.Create(DIV_OP49);
				adaptor.AddChild(root_0, DIV_OP49_tree);
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("product_operator", 17);
			LeaveRule("product_operator", 17);
			Leave_product_operator();
		}
		DebugLocation(300, 23);
		} finally { DebugExitRule(GrammarFileName, "product_operator"); }
		return retval;

	}
	// $ANTLR end "product_operator"

	public class record_literal_init_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_record_literal_init();
	partial void Leave_record_literal_init();

	// $ANTLR start "record_literal_init"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:306:1: record_literal_init : name= IDENTIFIER OPEN_BRACE ( field_list )? CLOSE_BRACE -> ^( RECORD_CREATION_NODE $name ^( FIELD_ASSIGN_LIST ( field_list )? ) ) ;
	[GrammarRule("record_literal_init")]
	private TigerParser.record_literal_init_return record_literal_init()
	{
		Enter_record_literal_init();
		EnterRule("record_literal_init", 18);
		TraceIn("record_literal_init", 18);
		TigerParser.record_literal_init_return retval = new TigerParser.record_literal_init_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name=null;
		IToken OPEN_BRACE50=null;
		IToken CLOSE_BRACE52=null;
		TigerParser.field_list_return field_list51 = default(TigerParser.field_list_return);

		CommonTree name_tree=null;
		CommonTree OPEN_BRACE50_tree=null;
		CommonTree CLOSE_BRACE52_tree=null;
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleSubtreeStream stream_field_list=new RewriteRuleSubtreeStream(adaptor,"rule field_list");
		try { DebugEnterRule(GrammarFileName, "record_literal_init");
		DebugLocation(306, 71);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:307:2: (name= IDENTIFIER OPEN_BRACE ( field_list )? CLOSE_BRACE -> ^( RECORD_CREATION_NODE $name ^( FIELD_ASSIGN_LIST ( field_list )? ) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:307:4: name= IDENTIFIER OPEN_BRACE ( field_list )? CLOSE_BRACE
			{
			DebugLocation(307, 9);
			name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_record_literal_init1613); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name);

			DebugLocation(307, 23);
			OPEN_BRACE50=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_record_literal_init1616); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE50);

			DebugLocation(307, 35);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:307:35: ( field_list )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==IDENTIFIER))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:307:35: field_list
				{
				DebugLocation(307, 35);
				PushFollow(Follow._field_list_in_record_literal_init1619);
				field_list51=field_list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_field_list.Add(field_list51.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(15); }

			DebugLocation(307, 48);
			CLOSE_BRACE52=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_record_literal_init1623); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE52);



			{
			// AST REWRITE
			// elements: name, field_list
			// token labels: name
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 308:2: -> ^( RECORD_CREATION_NODE $name ^( FIELD_ASSIGN_LIST ( field_list )? ) )
			{
				DebugLocation(308, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:308:5: ^( RECORD_CREATION_NODE $name ^( FIELD_ASSIGN_LIST ( field_list )? ) )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(308, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RECORD_CREATION_NODE, "RECORD_CREATION_NODE"), root_1);

				DebugLocation(308, 30);
				adaptor.AddChild(root_1, stream_name.NextNode());
				DebugLocation(308, 37);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:308:37: ^( FIELD_ASSIGN_LIST ( field_list )? )
				{
				CommonTree root_2 = (CommonTree)adaptor.Nil();
				DebugLocation(308, 39);
				root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FIELD_ASSIGN_LIST, "FIELD_ASSIGN_LIST"), root_2);

				DebugLocation(308, 59);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:308:59: ( field_list )?
				if ( stream_field_list.HasNext )
				{
					DebugLocation(308, 59);
					adaptor.AddChild(root_2, stream_field_list.NextTree());

				}
				stream_field_list.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("record_literal_init", 18);
			LeaveRule("record_literal_init", 18);
			Leave_record_literal_init();
		}
		DebugLocation(308, 71);
		} finally { DebugExitRule(GrammarFileName, "record_literal_init"); }
		return retval;

	}
	// $ANTLR end "record_literal_init"

	public class field_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field_list();
	partial void Leave_field_list();

	// $ANTLR start "field_list"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:310:1: field_list : field_assign ( COMMA field_assign )* -> ( field_assign )+ ;
	[GrammarRule("field_list")]
	private TigerParser.field_list_return field_list()
	{
		Enter_field_list();
		EnterRule("field_list", 19);
		TraceIn("field_list", 19);
		TigerParser.field_list_return retval = new TigerParser.field_list_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken COMMA54=null;
		TigerParser.field_assign_return field_assign53 = default(TigerParser.field_assign_return);
		TigerParser.field_assign_return field_assign55 = default(TigerParser.field_assign_return);

		CommonTree COMMA54_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_field_assign=new RewriteRuleSubtreeStream(adaptor,"rule field_assign");
		try { DebugEnterRule(GrammarFileName, "field_list");
		DebugLocation(310, 18);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:311:2: ( field_assign ( COMMA field_assign )* -> ( field_assign )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:311:4: field_assign ( COMMA field_assign )*
			{
			DebugLocation(311, 4);
			PushFollow(Follow._field_assign_in_field_list1655);
			field_assign53=field_assign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_field_assign.Add(field_assign53.Tree);
			DebugLocation(311, 18);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:311:18: ( COMMA field_assign )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==COMMA))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:311:19: COMMA field_assign
					{
					DebugLocation(311, 19);
					COMMA54=(IToken)Match(input,COMMA,Follow._COMMA_in_field_list1659); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA54);

					DebugLocation(311, 26);
					PushFollow(Follow._field_assign_in_field_list1662);
					field_assign55=field_assign();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_field_assign.Add(field_assign55.Tree);

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }



			{
			// AST REWRITE
			// elements: field_assign
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 312:2: -> ( field_assign )+
			{
				DebugLocation(312, 5);
				if ( !(stream_field_assign.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_field_assign.HasNext )
				{
					DebugLocation(312, 5);
					adaptor.AddChild(root_0, stream_field_assign.NextTree());

				}
				stream_field_assign.Reset();

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field_list", 19);
			LeaveRule("field_list", 19);
			Leave_field_list();
		}
		DebugLocation(312, 18);
		} finally { DebugExitRule(GrammarFileName, "field_list"); }
		return retval;

	}
	// $ANTLR end "field_list"

	public class field_assign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field_assign();
	partial void Leave_field_assign();

	// $ANTLR start "field_assign"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:314:1: field_assign : field_id= IDENTIFIER EQUAL_OP value= expression -> ^( FIELD_ASSIGN $field_id $value) ;
	[GrammarRule("field_assign")]
	private TigerParser.field_assign_return field_assign()
	{
		Enter_field_assign();
		EnterRule("field_assign", 20);
		TraceIn("field_assign", 20);
		TigerParser.field_assign_return retval = new TigerParser.field_assign_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken field_id=null;
		IToken EQUAL_OP56=null;
		TigerParser.expression_return value = default(TigerParser.expression_return);

		CommonTree field_id_tree=null;
		CommonTree EQUAL_OP56_tree=null;
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_EQUAL_OP=new RewriteRuleITokenStream(adaptor,"token EQUAL_OP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "field_assign");
		DebugLocation(314, 39);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:315:2: (field_id= IDENTIFIER EQUAL_OP value= expression -> ^( FIELD_ASSIGN $field_id $value) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:315:5: field_id= IDENTIFIER EQUAL_OP value= expression
			{
			DebugLocation(315, 14);
			field_id=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_field_assign1687); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(field_id);

			DebugLocation(315, 30);
			EQUAL_OP56=(IToken)Match(input,EQUAL_OP,Follow._EQUAL_OP_in_field_assign1692); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EQUAL_OP.Add(EQUAL_OP56);

			DebugLocation(315, 48);
			PushFollow(Follow._expression_in_field_assign1701);
			value=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(value.Tree);


			{
			// AST REWRITE
			// elements: value, field_id
			// token labels: field_id
			// rule labels: retval, value
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_field_id=new RewriteRuleITokenStream(adaptor,"token field_id",field_id);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value",value!=null?value.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 316:2: -> ^( FIELD_ASSIGN $field_id $value)
			{
				DebugLocation(316, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:316:5: ^( FIELD_ASSIGN $field_id $value)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(316, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FIELD_ASSIGN, "FIELD_ASSIGN"), root_1);

				DebugLocation(316, 21);
				adaptor.AddChild(root_1, stream_field_id.NextNode());
				DebugLocation(316, 33);
				adaptor.AddChild(root_1, stream_value.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field_assign", 20);
			LeaveRule("field_assign", 20);
			Leave_field_assign();
		}
		DebugLocation(316, 39);
		} finally { DebugExitRule(GrammarFileName, "field_assign"); }
		return retval;

	}
	// $ANTLR end "field_assign"

	public class array_creation_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_array_creation();
	partial void Leave_array_creation();

	// $ANTLR start "array_creation"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:318:1: array_creation : name= IDENTIFIER OPEN_BRACKET length= expression CLOSE_BRACKET KW_OF init_value= expression -> ^( ARRAY_CREATION_NODE $name $length $init_value) ;
	[GrammarRule("array_creation")]
	private TigerParser.array_creation_return array_creation()
	{
		Enter_array_creation();
		EnterRule("array_creation", 21);
		TraceIn("array_creation", 21);
		TigerParser.array_creation_return retval = new TigerParser.array_creation_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name=null;
		IToken OPEN_BRACKET57=null;
		IToken CLOSE_BRACKET58=null;
		IToken KW_OF59=null;
		TigerParser.expression_return length = default(TigerParser.expression_return);
		TigerParser.expression_return init_value = default(TigerParser.expression_return);

		CommonTree name_tree=null;
		CommonTree OPEN_BRACKET57_tree=null;
		CommonTree CLOSE_BRACKET58_tree=null;
		CommonTree KW_OF59_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACKET=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACKET");
		RewriteRuleITokenStream stream_KW_OF=new RewriteRuleITokenStream(adaptor,"token KW_OF");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_CLOSE_BRACKET=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACKET");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "array_creation");
		DebugLocation(318, 1);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:319:2: (name= IDENTIFIER OPEN_BRACKET length= expression CLOSE_BRACKET KW_OF init_value= expression -> ^( ARRAY_CREATION_NODE $name $length $init_value) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:319:4: name= IDENTIFIER OPEN_BRACKET length= expression CLOSE_BRACKET KW_OF init_value= expression
			{
			DebugLocation(319, 9);
			name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_array_creation1730); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name);

			DebugLocation(319, 24);
			OPEN_BRACKET57=(IToken)Match(input,OPEN_BRACKET,Follow._OPEN_BRACKET_in_array_creation1734); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACKET.Add(OPEN_BRACKET57);

			DebugLocation(319, 47);
			PushFollow(Follow._expression_in_array_creation1743);
			length=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(length.Tree);
			DebugLocation(319, 63);
			CLOSE_BRACKET58=(IToken)Match(input,CLOSE_BRACKET,Follow._CLOSE_BRACKET_in_array_creation1748); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACKET.Add(CLOSE_BRACKET58);

			DebugLocation(319, 79);
			KW_OF59=(IToken)Match(input,KW_OF,Follow._KW_OF_in_array_creation1752); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_OF.Add(KW_OF59);

			DebugLocation(319, 98);
			PushFollow(Follow._expression_in_array_creation1760);
			init_value=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(init_value.Tree);


			{
			// AST REWRITE
			// elements: init_value, length, name
			// token labels: name
			// rule labels: retval, length, init_value
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_length=new RewriteRuleSubtreeStream(adaptor,"rule length",length!=null?length.Tree:null);
			RewriteRuleSubtreeStream stream_init_value=new RewriteRuleSubtreeStream(adaptor,"rule init_value",init_value!=null?init_value.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 320:2: -> ^( ARRAY_CREATION_NODE $name $length $init_value)
			{
				DebugLocation(320, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:320:5: ^( ARRAY_CREATION_NODE $name $length $init_value)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(320, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARRAY_CREATION_NODE, "ARRAY_CREATION_NODE"), root_1);

				DebugLocation(320, 29);
				adaptor.AddChild(root_1, stream_name.NextNode());
				DebugLocation(320, 37);
				adaptor.AddChild(root_1, stream_length.NextTree());
				DebugLocation(320, 49);
				adaptor.AddChild(root_1, stream_init_value.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("array_creation", 21);
			LeaveRule("array_creation", 21);
			Leave_array_creation();
		}
		DebugLocation(321, 1);
		} finally { DebugExitRule(GrammarFileName, "array_creation"); }
		return retval;

	}
	// $ANTLR end "array_creation"

	public class high_acces_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_high_acces();
	partial void Leave_high_acces();

	// $ANTLR start "high_acces"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:323:1: high_acces : ( subscript | field );
	[GrammarRule("high_acces")]
	private TigerParser.high_acces_return high_acces()
	{
		Enter_high_acces();
		EnterRule("high_acces", 22);
		TraceIn("high_acces", 22);
		TigerParser.high_acces_return retval = new TigerParser.high_acces_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.subscript_return subscript60 = default(TigerParser.subscript_return);
		TigerParser.field_return field61 = default(TigerParser.field_return);


		try { DebugEnterRule(GrammarFileName, "high_acces");
		DebugLocation(323, 9);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:324:2: ( subscript | field )
			int alt17=2;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==OPEN_BRACKET))
			{
				alt17=1;
			}
			else if ((LA17_0==POINT))
			{
				alt17=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:324:4: subscript
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(324, 4);
				PushFollow(Follow._subscript_in_high_acces1795);
				subscript60=subscript();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subscript60.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:325:4: field
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(325, 4);
				PushFollow(Follow._field_in_high_acces1800);
				field61=field();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, field61.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("high_acces", 22);
			LeaveRule("high_acces", 22);
			Leave_high_acces();
		}
		DebugLocation(325, 9);
		} finally { DebugExitRule(GrammarFileName, "high_acces"); }
		return retval;

	}
	// $ANTLR end "high_acces"

	public class subscript_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_subscript();
	partial void Leave_subscript();

	// $ANTLR start "subscript"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:327:1: subscript : OPEN_BRACKET index= expression CLOSE_BRACKET -> ^( SUBSCRIPT_ACCES $index) ;
	[GrammarRule("subscript")]
	private TigerParser.subscript_return subscript()
	{
		Enter_subscript();
		EnterRule("subscript", 23);
		TraceIn("subscript", 23);
		TigerParser.subscript_return retval = new TigerParser.subscript_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken OPEN_BRACKET62=null;
		IToken CLOSE_BRACKET63=null;
		TigerParser.expression_return index = default(TigerParser.expression_return);

		CommonTree OPEN_BRACKET62_tree=null;
		CommonTree CLOSE_BRACKET63_tree=null;
		RewriteRuleITokenStream stream_OPEN_BRACKET=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACKET");
		RewriteRuleITokenStream stream_CLOSE_BRACKET=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACKET");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "subscript");
		DebugLocation(327, 30);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:328:2: ( OPEN_BRACKET index= expression CLOSE_BRACKET -> ^( SUBSCRIPT_ACCES $index) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:328:4: OPEN_BRACKET index= expression CLOSE_BRACKET
			{
			DebugLocation(328, 4);
			OPEN_BRACKET62=(IToken)Match(input,OPEN_BRACKET,Follow._OPEN_BRACKET_in_subscript1812); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_BRACKET.Add(OPEN_BRACKET62);

			DebugLocation(328, 24);
			PushFollow(Follow._expression_in_subscript1819);
			index=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(index.Tree);
			DebugLocation(328, 38);
			CLOSE_BRACKET63=(IToken)Match(input,CLOSE_BRACKET,Follow._CLOSE_BRACKET_in_subscript1822); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_BRACKET.Add(CLOSE_BRACKET63);



			{
			// AST REWRITE
			// elements: index
			// token labels: 
			// rule labels: retval, index
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_index=new RewriteRuleSubtreeStream(adaptor,"rule index",index!=null?index.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 329:2: -> ^( SUBSCRIPT_ACCES $index)
			{
				DebugLocation(329, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:329:5: ^( SUBSCRIPT_ACCES $index)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(329, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SUBSCRIPT_ACCES, "SUBSCRIPT_ACCES"), root_1);

				DebugLocation(329, 24);
				adaptor.AddChild(root_1, stream_index.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("subscript", 23);
			LeaveRule("subscript", 23);
			Leave_subscript();
		}
		DebugLocation(329, 30);
		} finally { DebugExitRule(GrammarFileName, "subscript"); }
		return retval;

	}
	// $ANTLR end "subscript"

	public class field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field();
	partial void Leave_field();

	// $ANTLR start "field"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:330:1: field : POINT field_name= IDENTIFIER -> ^( FIELD_ACCES $field_name) ;
	[GrammarRule("field")]
	private TigerParser.field_return field()
	{
		Enter_field();
		EnterRule("field", 24);
		TraceIn("field", 24);
		TigerParser.field_return retval = new TigerParser.field_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken field_name=null;
		IToken POINT64=null;

		CommonTree field_name_tree=null;
		CommonTree POINT64_tree=null;
		RewriteRuleITokenStream stream_POINT=new RewriteRuleITokenStream(adaptor,"token POINT");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");

		try { DebugEnterRule(GrammarFileName, "field");
		DebugLocation(330, 31);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:331:2: ( POINT field_name= IDENTIFIER -> ^( FIELD_ACCES $field_name) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:331:4: POINT field_name= IDENTIFIER
			{
			DebugLocation(331, 4);
			POINT64=(IToken)Match(input,POINT,Follow._POINT_in_field1844); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_POINT.Add(POINT64);

			DebugLocation(331, 21);
			field_name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_field1850); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(field_name);



			{
			// AST REWRITE
			// elements: field_name
			// token labels: field_name
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_field_name=new RewriteRuleITokenStream(adaptor,"token field_name",field_name);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 332:2: -> ^( FIELD_ACCES $field_name)
			{
				DebugLocation(332, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:332:5: ^( FIELD_ACCES $field_name)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(332, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FIELD_ACCES, "FIELD_ACCES"), root_1);

				DebugLocation(332, 20);
				adaptor.AddChild(root_1, stream_field_name.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field", 24);
			LeaveRule("field", 24);
			Leave_field();
		}
		DebugLocation(332, 31);
		} finally { DebugExitRule(GrammarFileName, "field"); }
		return retval;

	}
	// $ANTLR end "field"

	public class call_function_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_call_function_expr();
	partial void Leave_call_function_expr();

	// $ANTLR start "call_function_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:338:1: call_function_expr : name= IDENTIFIER OPEN_PARENTHESIS ( expr_list )? CLOSE_PARENTHESIS -> ^( CALL_FUNCTION_NODE $name ^( PARAMETERS_CALL ( expr_list )? ) ) ;
	[GrammarRule("call_function_expr")]
	private TigerParser.call_function_expr_return call_function_expr()
	{
		Enter_call_function_expr();
		EnterRule("call_function_expr", 25);
		TraceIn("call_function_expr", 25);
		TigerParser.call_function_expr_return retval = new TigerParser.call_function_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name=null;
		IToken OPEN_PARENTHESIS65=null;
		IToken CLOSE_PARENTHESIS67=null;
		TigerParser.expr_list_return expr_list66 = default(TigerParser.expr_list_return);

		CommonTree name_tree=null;
		CommonTree OPEN_PARENTHESIS65_tree=null;
		CommonTree CLOSE_PARENTHESIS67_tree=null;
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_OPEN_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token OPEN_PARENTHESIS");
		RewriteRuleITokenStream stream_CLOSE_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token CLOSE_PARENTHESIS");
		RewriteRuleSubtreeStream stream_expr_list=new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
		try { DebugEnterRule(GrammarFileName, "call_function_expr");
		DebugLocation(338, 67);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:339:2: (name= IDENTIFIER OPEN_PARENTHESIS ( expr_list )? CLOSE_PARENTHESIS -> ^( CALL_FUNCTION_NODE $name ^( PARAMETERS_CALL ( expr_list )? ) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:339:5: name= IDENTIFIER OPEN_PARENTHESIS ( expr_list )? CLOSE_PARENTHESIS
			{
			DebugLocation(339, 10);
			name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_call_function_expr1882); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name);

			DebugLocation(339, 27);
			OPEN_PARENTHESIS65=(IToken)Match(input,OPEN_PARENTHESIS,Follow._OPEN_PARENTHESIS_in_call_function_expr1888); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_PARENTHESIS.Add(OPEN_PARENTHESIS65);

			DebugLocation(339, 47);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:339:47: ( expr_list )?
			int alt18=2;
			try { DebugEnterSubRule(18);
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==KW_BREAK||LA18_0==KW_FOR||LA18_0==KW_IF||(LA18_0>=KW_LET && LA18_0<=KW_NIL)||LA18_0==KW_WHILE||LA18_0==OPEN_PARENTHESIS||LA18_0==MINUS_OP||LA18_0==IDENTIFIER||LA18_0==INT_CONSTANT||LA18_0==STRING_CONSTANT))
			{
				alt18=1;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:339:47: expr_list
				{
				DebugLocation(339, 47);
				PushFollow(Follow._expr_list_in_call_function_expr1893);
				expr_list66=expr_list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_list.Add(expr_list66.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(18); }

			DebugLocation(339, 61);
			CLOSE_PARENTHESIS67=(IToken)Match(input,CLOSE_PARENTHESIS,Follow._CLOSE_PARENTHESIS_in_call_function_expr1899); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_PARENTHESIS.Add(CLOSE_PARENTHESIS67);



			{
			// AST REWRITE
			// elements: name, expr_list
			// token labels: name
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 340:2: -> ^( CALL_FUNCTION_NODE $name ^( PARAMETERS_CALL ( expr_list )? ) )
			{
				DebugLocation(340, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:340:5: ^( CALL_FUNCTION_NODE $name ^( PARAMETERS_CALL ( expr_list )? ) )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(340, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CALL_FUNCTION_NODE, "CALL_FUNCTION_NODE"), root_1);

				DebugLocation(340, 29);
				adaptor.AddChild(root_1, stream_name.NextNode());
				DebugLocation(340, 37);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:340:37: ^( PARAMETERS_CALL ( expr_list )? )
				{
				CommonTree root_2 = (CommonTree)adaptor.Nil();
				DebugLocation(340, 39);
				root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAMETERS_CALL, "PARAMETERS_CALL"), root_2);

				DebugLocation(340, 56);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:340:56: ( expr_list )?
				if ( stream_expr_list.HasNext )
				{
					DebugLocation(340, 56);
					adaptor.AddChild(root_2, stream_expr_list.NextTree());

				}
				stream_expr_list.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("call_function_expr", 25);
			LeaveRule("call_function_expr", 25);
			Leave_call_function_expr();
		}
		DebugLocation(340, 67);
		} finally { DebugExitRule(GrammarFileName, "call_function_expr"); }
		return retval;

	}
	// $ANTLR end "call_function_expr"

	public class expr_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_list();
	partial void Leave_expr_list();

	// $ANTLR start "expr_list"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:342:1: expr_list : expression ( COMMA expression )* -> ( expression )+ ;
	[GrammarRule("expr_list")]
	private TigerParser.expr_list_return expr_list()
	{
		Enter_expr_list();
		EnterRule("expr_list", 26);
		TraceIn("expr_list", 26);
		TigerParser.expr_list_return retval = new TigerParser.expr_list_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken COMMA69=null;
		TigerParser.expression_return expression68 = default(TigerParser.expression_return);
		TigerParser.expression_return expression70 = default(TigerParser.expression_return);

		CommonTree COMMA69_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expr_list");
		DebugLocation(342, 16);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:343:2: ( expression ( COMMA expression )* -> ( expression )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:343:4: expression ( COMMA expression )*
			{
			DebugLocation(343, 4);
			PushFollow(Follow._expression_in_expr_list1931);
			expression68=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression68.Tree);
			DebugLocation(343, 16);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:343:16: ( COMMA expression )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==COMMA))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:343:17: COMMA expression
					{
					DebugLocation(343, 17);
					COMMA69=(IToken)Match(input,COMMA,Follow._COMMA_in_expr_list1935); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA69);

					DebugLocation(343, 24);
					PushFollow(Follow._expression_in_expr_list1938);
					expression70=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression70.Tree);

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 344:2: -> ( expression )+
			{
				DebugLocation(344, 5);
				if ( !(stream_expression.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_expression.HasNext )
				{
					DebugLocation(344, 5);
					adaptor.AddChild(root_0, stream_expression.NextTree());

				}
				stream_expression.Reset();

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_list", 26);
			LeaveRule("expr_list", 26);
			Leave_expr_list();
		}
		DebugLocation(344, 16);
		} finally { DebugExitRule(GrammarFileName, "expr_list"); }
		return retval;

	}
	// $ANTLR end "expr_list"

	public class assign_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assign_expr();
	partial void Leave_assign_expr();

	// $ANTLR start "assign_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:350:1: assign_expr : ASSIGN_OP expression ;
	[GrammarRule("assign_expr")]
	private TigerParser.assign_expr_return assign_expr()
	{
		Enter_assign_expr();
		EnterRule("assign_expr", 27);
		TraceIn("assign_expr", 27);
		TigerParser.assign_expr_return retval = new TigerParser.assign_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken ASSIGN_OP71=null;
		TigerParser.expression_return expression72 = default(TigerParser.expression_return);

		CommonTree ASSIGN_OP71_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign_expr");
		DebugLocation(350, 24);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:351:2: ( ASSIGN_OP expression )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:351:4: ASSIGN_OP expression
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(351, 13);
			ASSIGN_OP71=(IToken)Match(input,ASSIGN_OP,Follow._ASSIGN_OP_in_assign_expr1960); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN_OP71_tree = (CommonTree)adaptor.Create(ASSIGN_OP71);
			root_0 = (CommonTree)adaptor.BecomeRoot(ASSIGN_OP71_tree, root_0);
			}
			DebugLocation(351, 15);
			PushFollow(Follow._expression_in_assign_expr1963);
			expression72=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression72.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assign_expr", 27);
			LeaveRule("assign_expr", 27);
			Leave_assign_expr();
		}
		DebugLocation(351, 24);
		} finally { DebugExitRule(GrammarFileName, "assign_expr"); }
		return retval;

	}
	// $ANTLR end "assign_expr"

	public class flow_control_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_flow_control_expr();
	partial void Leave_flow_control_expr();

	// $ANTLR start "flow_control_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:357:1: flow_control_expr : ( conditional_jump | while_loop_expr | for_loop_expr | break_expr );
	[GrammarRule("flow_control_expr")]
	private TigerParser.flow_control_expr_return flow_control_expr()
	{
		Enter_flow_control_expr();
		EnterRule("flow_control_expr", 28);
		TraceIn("flow_control_expr", 28);
		TigerParser.flow_control_expr_return retval = new TigerParser.flow_control_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.conditional_jump_return conditional_jump73 = default(TigerParser.conditional_jump_return);
		TigerParser.while_loop_expr_return while_loop_expr74 = default(TigerParser.while_loop_expr_return);
		TigerParser.for_loop_expr_return for_loop_expr75 = default(TigerParser.for_loop_expr_return);
		TigerParser.break_expr_return break_expr76 = default(TigerParser.break_expr_return);


		try { DebugEnterRule(GrammarFileName, "flow_control_expr");
		DebugLocation(357, 14);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:358:2: ( conditional_jump | while_loop_expr | for_loop_expr | break_expr )
			int alt20=4;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			switch (input.LA(1))
			{
			case KW_IF:
				{
				alt20=1;
				}
				break;
			case KW_WHILE:
				{
				alt20=2;
				}
				break;
			case KW_FOR:
				{
				alt20=3;
				}
				break;
			case KW_BREAK:
				{
				alt20=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:358:4: conditional_jump
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(358, 4);
				PushFollow(Follow._conditional_jump_in_flow_control_expr1976);
				conditional_jump73=conditional_jump();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditional_jump73.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:359:4: while_loop_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(359, 4);
				PushFollow(Follow._while_loop_expr_in_flow_control_expr1981);
				while_loop_expr74=while_loop_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_loop_expr74.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:360:4: for_loop_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(360, 4);
				PushFollow(Follow._for_loop_expr_in_flow_control_expr1986);
				for_loop_expr75=for_loop_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_loop_expr75.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:361:4: break_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(361, 4);
				PushFollow(Follow._break_expr_in_flow_control_expr1991);
				break_expr76=break_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, break_expr76.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("flow_control_expr", 28);
			LeaveRule("flow_control_expr", 28);
			Leave_flow_control_expr();
		}
		DebugLocation(361, 14);
		} finally { DebugExitRule(GrammarFileName, "flow_control_expr"); }
		return retval;

	}
	// $ANTLR end "flow_control_expr"

	public class conditional_jump_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conditional_jump();
	partial void Leave_conditional_jump();

	// $ANTLR start "conditional_jump"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:364:1: conditional_jump : ( ( KW_IF expression KW_THEN expression KW_ELSE )=> if_then_else_expr | if_then_expr );
	[GrammarRule("conditional_jump")]
	private TigerParser.conditional_jump_return conditional_jump()
	{
		Enter_conditional_jump();
		EnterRule("conditional_jump", 29);
		TraceIn("conditional_jump", 29);
		TigerParser.conditional_jump_return retval = new TigerParser.conditional_jump_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.if_then_else_expr_return if_then_else_expr77 = default(TigerParser.if_then_else_expr_return);
		TigerParser.if_then_expr_return if_then_expr78 = default(TigerParser.if_then_expr_return);


		try { DebugEnterRule(GrammarFileName, "conditional_jump");
		DebugLocation(364, 17);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:365:2: ( ( KW_IF expression KW_THEN expression KW_ELSE )=> if_then_else_expr | if_then_expr )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==KW_IF))
			{
				int LA21_1 = input.LA(2);

				if ((EvaluatePredicate(synpred4_Tiger_fragment)))
				{
					alt21=1;
				}
				else if ((true))
				{
					alt21=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 21, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:365:4: ( KW_IF expression KW_THEN expression KW_ELSE )=> if_then_else_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(366, 5);
				PushFollow(Follow._if_then_else_expr_in_conditional_jump2021);
				if_then_else_expr77=if_then_else_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_then_else_expr77.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:367:5: if_then_expr
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(367, 5);
				PushFollow(Follow._if_then_expr_in_conditional_jump2027);
				if_then_expr78=if_then_expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_then_expr78.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditional_jump", 29);
			LeaveRule("conditional_jump", 29);
			Leave_conditional_jump();
		}
		DebugLocation(367, 17);
		} finally { DebugExitRule(GrammarFileName, "conditional_jump"); }
		return retval;

	}
	// $ANTLR end "conditional_jump"

	public class if_then_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_if_then_expr();
	partial void Leave_if_then_expr();

	// $ANTLR start "if_then_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:368:1: if_then_expr : KW_IF cond= expression KW_THEN then_expr= expression -> ^( IF_THEN_NODE $cond $then_expr) ;
	[GrammarRule("if_then_expr")]
	private TigerParser.if_then_expr_return if_then_expr()
	{
		Enter_if_then_expr();
		EnterRule("if_then_expr", 30);
		TraceIn("if_then_expr", 30);
		TigerParser.if_then_expr_return retval = new TigerParser.if_then_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken KW_IF79=null;
		IToken KW_THEN80=null;
		TigerParser.expression_return cond = default(TigerParser.expression_return);
		TigerParser.expression_return then_expr = default(TigerParser.expression_return);

		CommonTree KW_IF79_tree=null;
		CommonTree KW_THEN80_tree=null;
		RewriteRuleITokenStream stream_KW_THEN=new RewriteRuleITokenStream(adaptor,"token KW_THEN");
		RewriteRuleITokenStream stream_KW_IF=new RewriteRuleITokenStream(adaptor,"token KW_IF");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "if_then_expr");
		DebugLocation(368, 41);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:369:2: ( KW_IF cond= expression KW_THEN then_expr= expression -> ^( IF_THEN_NODE $cond $then_expr) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:369:4: KW_IF cond= expression KW_THEN then_expr= expression
			{
			DebugLocation(369, 4);
			KW_IF79=(IToken)Match(input,KW_IF,Follow._KW_IF_in_if_then_expr2036); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_IF.Add(KW_IF79);

			DebugLocation(369, 15);
			PushFollow(Follow._expression_in_if_then_expr2042);
			cond=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(cond.Tree);
			DebugLocation(369, 29);
			KW_THEN80=(IToken)Match(input,KW_THEN,Follow._KW_THEN_in_if_then_expr2045); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_THEN.Add(KW_THEN80);

			DebugLocation(369, 48);
			PushFollow(Follow._expression_in_if_then_expr2052);
			then_expr=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(then_expr.Tree);


			{
			// AST REWRITE
			// elements: then_expr, cond
			// token labels: 
			// rule labels: retval, then_expr, cond
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_then_expr=new RewriteRuleSubtreeStream(adaptor,"rule then_expr",then_expr!=null?then_expr.Tree:null);
			RewriteRuleSubtreeStream stream_cond=new RewriteRuleSubtreeStream(adaptor,"rule cond",cond!=null?cond.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 370:2: -> ^( IF_THEN_NODE $cond $then_expr)
			{
				DebugLocation(370, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:370:5: ^( IF_THEN_NODE $cond $then_expr)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(370, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IF_THEN_NODE, "IF_THEN_NODE"), root_1);

				DebugLocation(370, 21);
				adaptor.AddChild(root_1, stream_cond.NextTree());
				DebugLocation(370, 29);
				adaptor.AddChild(root_1, stream_then_expr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("if_then_expr", 30);
			LeaveRule("if_then_expr", 30);
			Leave_if_then_expr();
		}
		DebugLocation(370, 41);
		} finally { DebugExitRule(GrammarFileName, "if_then_expr"); }
		return retval;

	}
	// $ANTLR end "if_then_expr"

	public class if_then_else_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_if_then_else_expr();
	partial void Leave_if_then_else_expr();

	// $ANTLR start "if_then_else_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:371:1: if_then_else_expr : KW_IF cond= expression KW_THEN then_expr= expression KW_ELSE else_expr= expression -> ^( IF_THEN_ELSE_NODE $cond $then_expr $else_expr) ;
	[GrammarRule("if_then_else_expr")]
	private TigerParser.if_then_else_expr_return if_then_else_expr()
	{
		Enter_if_then_else_expr();
		EnterRule("if_then_else_expr", 31);
		TraceIn("if_then_else_expr", 31);
		TigerParser.if_then_else_expr_return retval = new TigerParser.if_then_else_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken KW_IF81=null;
		IToken KW_THEN82=null;
		IToken KW_ELSE83=null;
		TigerParser.expression_return cond = default(TigerParser.expression_return);
		TigerParser.expression_return then_expr = default(TigerParser.expression_return);
		TigerParser.expression_return else_expr = default(TigerParser.expression_return);

		CommonTree KW_IF81_tree=null;
		CommonTree KW_THEN82_tree=null;
		CommonTree KW_ELSE83_tree=null;
		RewriteRuleITokenStream stream_KW_THEN=new RewriteRuleITokenStream(adaptor,"token KW_THEN");
		RewriteRuleITokenStream stream_KW_IF=new RewriteRuleITokenStream(adaptor,"token KW_IF");
		RewriteRuleITokenStream stream_KW_ELSE=new RewriteRuleITokenStream(adaptor,"token KW_ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "if_then_else_expr");
		DebugLocation(371, 59);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:372:2: ( KW_IF cond= expression KW_THEN then_expr= expression KW_ELSE else_expr= expression -> ^( IF_THEN_ELSE_NODE $cond $then_expr $else_expr) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:372:4: KW_IF cond= expression KW_THEN then_expr= expression KW_ELSE else_expr= expression
			{
			DebugLocation(372, 4);
			KW_IF81=(IToken)Match(input,KW_IF,Follow._KW_IF_in_if_then_else_expr2079); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_IF.Add(KW_IF81);

			DebugLocation(372, 17);
			PushFollow(Follow._expression_in_if_then_else_expr2087);
			cond=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(cond.Tree);
			DebugLocation(372, 31);
			KW_THEN82=(IToken)Match(input,KW_THEN,Follow._KW_THEN_in_if_then_else_expr2090); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_THEN.Add(KW_THEN82);

			DebugLocation(372, 51);
			PushFollow(Follow._expression_in_if_then_else_expr2098);
			then_expr=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(then_expr.Tree);
			DebugLocation(372, 65);
			KW_ELSE83=(IToken)Match(input,KW_ELSE,Follow._KW_ELSE_in_if_then_else_expr2101); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_ELSE.Add(KW_ELSE83);

			DebugLocation(372, 86);
			PushFollow(Follow._expression_in_if_then_else_expr2110);
			else_expr=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(else_expr.Tree);


			{
			// AST REWRITE
			// elements: else_expr, then_expr, cond
			// token labels: 
			// rule labels: retval, else_expr, then_expr, cond
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_else_expr=new RewriteRuleSubtreeStream(adaptor,"rule else_expr",else_expr!=null?else_expr.Tree:null);
			RewriteRuleSubtreeStream stream_then_expr=new RewriteRuleSubtreeStream(adaptor,"rule then_expr",then_expr!=null?then_expr.Tree:null);
			RewriteRuleSubtreeStream stream_cond=new RewriteRuleSubtreeStream(adaptor,"rule cond",cond!=null?cond.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 373:2: -> ^( IF_THEN_ELSE_NODE $cond $then_expr $else_expr)
			{
				DebugLocation(373, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:373:5: ^( IF_THEN_ELSE_NODE $cond $then_expr $else_expr)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(373, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IF_THEN_ELSE_NODE, "IF_THEN_ELSE_NODE"), root_1);

				DebugLocation(373, 26);
				adaptor.AddChild(root_1, stream_cond.NextTree());
				DebugLocation(373, 34);
				adaptor.AddChild(root_1, stream_then_expr.NextTree());
				DebugLocation(373, 47);
				adaptor.AddChild(root_1, stream_else_expr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("if_then_else_expr", 31);
			LeaveRule("if_then_else_expr", 31);
			Leave_if_then_else_expr();
		}
		DebugLocation(373, 59);
		} finally { DebugExitRule(GrammarFileName, "if_then_else_expr"); }
		return retval;

	}
	// $ANTLR end "if_then_else_expr"

	public class while_loop_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_while_loop_expr();
	partial void Leave_while_loop_expr();

	// $ANTLR start "while_loop_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:377:1: while_loop_expr : KW_WHILE expression KW_DO expression ;
	[GrammarRule("while_loop_expr")]
	private TigerParser.while_loop_expr_return while_loop_expr()
	{
		Enter_while_loop_expr();
		EnterRule("while_loop_expr", 32);
		TraceIn("while_loop_expr", 32);
		TigerParser.while_loop_expr_return retval = new TigerParser.while_loop_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken KW_WHILE84=null;
		IToken KW_DO86=null;
		TigerParser.expression_return expression85 = default(TigerParser.expression_return);
		TigerParser.expression_return expression87 = default(TigerParser.expression_return);

		CommonTree KW_WHILE84_tree=null;
		CommonTree KW_DO86_tree=null;

		try { DebugEnterRule(GrammarFileName, "while_loop_expr");
		DebugLocation(377, 46);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:378:2: ( KW_WHILE expression KW_DO expression )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:378:4: KW_WHILE expression KW_DO expression
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(378, 12);
			KW_WHILE84=(IToken)Match(input,KW_WHILE,Follow._KW_WHILE_in_while_loop_expr2144); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			KW_WHILE84_tree = (CommonTree)adaptor.Create(KW_WHILE84);
			root_0 = (CommonTree)adaptor.BecomeRoot(KW_WHILE84_tree, root_0);
			}
			DebugLocation(378, 15);
			PushFollow(Follow._expression_in_while_loop_expr2148);
			expression85=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression85.Tree);
			DebugLocation(378, 33);
			KW_DO86=(IToken)Match(input,KW_DO,Follow._KW_DO_in_while_loop_expr2152); if (state.failed) return retval;
			DebugLocation(378, 37);
			PushFollow(Follow._expression_in_while_loop_expr2157);
			expression87=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression87.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("while_loop_expr", 32);
			LeaveRule("while_loop_expr", 32);
			Leave_while_loop_expr();
		}
		DebugLocation(378, 46);
		} finally { DebugExitRule(GrammarFileName, "while_loop_expr"); }
		return retval;

	}
	// $ANTLR end "while_loop_expr"

	public class for_loop_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_for_loop_expr();
	partial void Leave_for_loop_expr();

	// $ANTLR start "for_loop_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:380:1: for_loop_expr : KW_FOR iter_var= IDENTIFIER ASSIGN_OP init_value= expression KW_TO cond= expression KW_DO iter_instr= expression -> ^( KW_FOR $cond $iter_var $init_value $iter_instr) ;
	[GrammarRule("for_loop_expr")]
	private TigerParser.for_loop_expr_return for_loop_expr()
	{
		Enter_for_loop_expr();
		EnterRule("for_loop_expr", 33);
		TraceIn("for_loop_expr", 33);
		TigerParser.for_loop_expr_return retval = new TigerParser.for_loop_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken iter_var=null;
		IToken KW_FOR88=null;
		IToken ASSIGN_OP89=null;
		IToken KW_TO90=null;
		IToken KW_DO91=null;
		TigerParser.expression_return init_value = default(TigerParser.expression_return);
		TigerParser.expression_return cond = default(TigerParser.expression_return);
		TigerParser.expression_return iter_instr = default(TigerParser.expression_return);

		CommonTree iter_var_tree=null;
		CommonTree KW_FOR88_tree=null;
		CommonTree ASSIGN_OP89_tree=null;
		CommonTree KW_TO90_tree=null;
		CommonTree KW_DO91_tree=null;
		RewriteRuleITokenStream stream_ASSIGN_OP=new RewriteRuleITokenStream(adaptor,"token ASSIGN_OP");
		RewriteRuleITokenStream stream_KW_DO=new RewriteRuleITokenStream(adaptor,"token KW_DO");
		RewriteRuleITokenStream stream_KW_FOR=new RewriteRuleITokenStream(adaptor,"token KW_FOR");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_KW_TO=new RewriteRuleITokenStream(adaptor,"token KW_TO");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "for_loop_expr");
		DebugLocation(380, 60);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:381:2: ( KW_FOR iter_var= IDENTIFIER ASSIGN_OP init_value= expression KW_TO cond= expression KW_DO iter_instr= expression -> ^( KW_FOR $cond $iter_var $init_value $iter_instr) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:381:4: KW_FOR iter_var= IDENTIFIER ASSIGN_OP init_value= expression KW_TO cond= expression KW_DO iter_instr= expression
			{
			DebugLocation(381, 4);
			KW_FOR88=(IToken)Match(input,KW_FOR,Follow._KW_FOR_in_for_loop_expr2168); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_FOR.Add(KW_FOR88);

			DebugLocation(381, 22);
			iter_var=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_for_loop_expr2176); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(iter_var);

			DebugLocation(381, 37);
			ASSIGN_OP89=(IToken)Match(input,ASSIGN_OP,Follow._ASSIGN_OP_in_for_loop_expr2180); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN_OP.Add(ASSIGN_OP89);

			DebugLocation(381, 60);
			PushFollow(Follow._expression_in_for_loop_expr2188);
			init_value=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(init_value.Tree);
			DebugLocation(381, 74);
			KW_TO90=(IToken)Match(input,KW_TO,Follow._KW_TO_in_for_loop_expr2191); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_TO.Add(KW_TO90);

			DebugLocation(381, 86);
			PushFollow(Follow._expression_in_for_loop_expr2198);
			cond=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(cond.Tree);
			DebugLocation(381, 100);
			KW_DO91=(IToken)Match(input,KW_DO,Follow._KW_DO_in_for_loop_expr2201); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_DO.Add(KW_DO91);

			DebugLocation(381, 118);
			PushFollow(Follow._expression_in_for_loop_expr2208);
			iter_instr=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(iter_instr.Tree);


			{
			// AST REWRITE
			// elements: KW_FOR, init_value, iter_var, cond, iter_instr
			// token labels: iter_var
			// rule labels: retval, init_value, cond, iter_instr
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_iter_var=new RewriteRuleITokenStream(adaptor,"token iter_var",iter_var);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_init_value=new RewriteRuleSubtreeStream(adaptor,"rule init_value",init_value!=null?init_value.Tree:null);
			RewriteRuleSubtreeStream stream_cond=new RewriteRuleSubtreeStream(adaptor,"rule cond",cond!=null?cond.Tree:null);
			RewriteRuleSubtreeStream stream_iter_instr=new RewriteRuleSubtreeStream(adaptor,"rule iter_instr",iter_instr!=null?iter_instr.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 382:2: -> ^( KW_FOR $cond $iter_var $init_value $iter_instr)
			{
				DebugLocation(382, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:382:4: ^( KW_FOR $cond $iter_var $init_value $iter_instr)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(382, 6);
				root_1 = (CommonTree)adaptor.BecomeRoot(stream_KW_FOR.NextNode(), root_1);

				DebugLocation(382, 15);
				adaptor.AddChild(root_1, stream_cond.NextTree());
				DebugLocation(382, 23);
				adaptor.AddChild(root_1, stream_iter_var.NextNode());
				DebugLocation(382, 35);
				adaptor.AddChild(root_1, stream_init_value.NextTree());
				DebugLocation(382, 49);
				adaptor.AddChild(root_1, stream_iter_instr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("for_loop_expr", 33);
			LeaveRule("for_loop_expr", 33);
			Leave_for_loop_expr();
		}
		DebugLocation(382, 60);
		} finally { DebugExitRule(GrammarFileName, "for_loop_expr"); }
		return retval;

	}
	// $ANTLR end "for_loop_expr"

	public class break_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_break_expr();
	partial void Leave_break_expr();

	// $ANTLR start "break_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:386:1: break_expr : KW_BREAK ;
	[GrammarRule("break_expr")]
	private TigerParser.break_expr_return break_expr()
	{
		Enter_break_expr();
		EnterRule("break_expr", 34);
		TraceIn("break_expr", 34);
		TigerParser.break_expr_return retval = new TigerParser.break_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken KW_BREAK92=null;

		CommonTree KW_BREAK92_tree=null;

		try { DebugEnterRule(GrammarFileName, "break_expr");
		DebugLocation(386, 12);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:387:2: ( KW_BREAK )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:387:4: KW_BREAK
			{
			root_0 = (CommonTree)adaptor.Nil();

			DebugLocation(387, 12);
			KW_BREAK92=(IToken)Match(input,KW_BREAK,Follow._KW_BREAK_in_break_expr2246); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			KW_BREAK92_tree = (CommonTree)adaptor.Create(KW_BREAK92);
			root_0 = (CommonTree)adaptor.BecomeRoot(KW_BREAK92_tree, root_0);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("break_expr", 34);
			LeaveRule("break_expr", 34);
			Leave_break_expr();
		}
		DebugLocation(387, 12);
		} finally { DebugExitRule(GrammarFileName, "break_expr"); }
		return retval;

	}
	// $ANTLR end "break_expr"

	public class let_in_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_let_in_expr();
	partial void Leave_let_in_expr();

	// $ANTLR start "let_in_expr"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:395:1: let_in_expr : KW_LET declaration_list KW_IN ( expr_seq )? KW_END -> ^( LET_INSTRUCTION_NODE declaration_list ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) ) ;
	[GrammarRule("let_in_expr")]
	private TigerParser.let_in_expr_return let_in_expr()
	{
		Enter_let_in_expr();
		EnterRule("let_in_expr", 35);
		TraceIn("let_in_expr", 35);
		TigerParser.let_in_expr_return retval = new TigerParser.let_in_expr_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken KW_LET93=null;
		IToken KW_IN95=null;
		IToken KW_END97=null;
		TigerParser.declaration_list_return declaration_list94 = default(TigerParser.declaration_list_return);
		TigerParser.expr_seq_return expr_seq96 = default(TigerParser.expr_seq_return);

		CommonTree KW_LET93_tree=null;
		CommonTree KW_IN95_tree=null;
		CommonTree KW_END97_tree=null;
		RewriteRuleITokenStream stream_KW_IN=new RewriteRuleITokenStream(adaptor,"token KW_IN");
		RewriteRuleITokenStream stream_KW_LET=new RewriteRuleITokenStream(adaptor,"token KW_LET");
		RewriteRuleITokenStream stream_KW_END=new RewriteRuleITokenStream(adaptor,"token KW_END");
		RewriteRuleSubtreeStream stream_declaration_list=new RewriteRuleSubtreeStream(adaptor,"rule declaration_list");
		RewriteRuleSubtreeStream stream_expr_seq=new RewriteRuleSubtreeStream(adaptor,"rule expr_seq");
		try { DebugEnterRule(GrammarFileName, "let_in_expr");
		DebugLocation(395, 1);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:396:2: ( KW_LET declaration_list KW_IN ( expr_seq )? KW_END -> ^( LET_INSTRUCTION_NODE declaration_list ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:396:4: KW_LET declaration_list KW_IN ( expr_seq )? KW_END
			{
			DebugLocation(396, 4);
			KW_LET93=(IToken)Match(input,KW_LET,Follow._KW_LET_in_let_in_expr2262); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_LET.Add(KW_LET93);

			DebugLocation(396, 13);
			PushFollow(Follow._declaration_list_in_let_in_expr2266);
			declaration_list94=declaration_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declaration_list.Add(declaration_list94.Tree);
			DebugLocation(396, 32);
			KW_IN95=(IToken)Match(input,KW_IN,Follow._KW_IN_in_let_in_expr2270); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_IN.Add(KW_IN95);

			DebugLocation(396, 40);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:396:40: ( expr_seq )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if ((LA22_0==KW_BREAK||LA22_0==KW_FOR||LA22_0==KW_IF||(LA22_0>=KW_LET && LA22_0<=KW_NIL)||LA22_0==KW_WHILE||LA22_0==OPEN_PARENTHESIS||LA22_0==MINUS_OP||LA22_0==IDENTIFIER||LA22_0==INT_CONSTANT||LA22_0==STRING_CONSTANT))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:396:40: expr_seq
				{
				DebugLocation(396, 40);
				PushFollow(Follow._expr_seq_in_let_in_expr2274);
				expr_seq96=expr_seq();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_seq.Add(expr_seq96.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(22); }

			DebugLocation(396, 52);
			KW_END97=(IToken)Match(input,KW_END,Follow._KW_END_in_let_in_expr2279); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_END.Add(KW_END97);



			{
			// AST REWRITE
			// elements: expr_seq, declaration_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 397:2: -> ^( LET_INSTRUCTION_NODE declaration_list ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) )
			{
				DebugLocation(397, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:397:5: ^( LET_INSTRUCTION_NODE declaration_list ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? ) )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(397, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(LET_INSTRUCTION_NODE, "LET_INSTRUCTION_NODE"), root_1);

				DebugLocation(397, 29);
				adaptor.AddChild(root_1, stream_declaration_list.NextTree());
				DebugLocation(397, 47);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:397:47: ^( EXPRESSION_SEQ_INSTR_NODE ( expr_seq )? )
				{
				CommonTree root_2 = (CommonTree)adaptor.Nil();
				DebugLocation(397, 49);
				root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(EXPRESSION_SEQ_INSTR_NODE, "EXPRESSION_SEQ_INSTR_NODE"), root_2);

				DebugLocation(397, 76);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:397:76: ( expr_seq )?
				if ( stream_expr_seq.HasNext )
				{
					DebugLocation(397, 76);
					adaptor.AddChild(root_2, stream_expr_seq.NextTree());

				}
				stream_expr_seq.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("let_in_expr", 35);
			LeaveRule("let_in_expr", 35);
			Leave_let_in_expr();
		}
		DebugLocation(398, 1);
		} finally { DebugExitRule(GrammarFileName, "let_in_expr"); }
		return retval;

	}
	// $ANTLR end "let_in_expr"

	public class expr_seq_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_seq();
	partial void Leave_expr_seq();

	// $ANTLR start "expr_seq"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:400:1: expr_seq : expression ( SEMICOLON expression )* -> ( expression )+ ;
	[GrammarRule("expr_seq")]
	private TigerParser.expr_seq_return expr_seq()
	{
		Enter_expr_seq();
		EnterRule("expr_seq", 36);
		TraceIn("expr_seq", 36);
		TigerParser.expr_seq_return retval = new TigerParser.expr_seq_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken SEMICOLON99=null;
		TigerParser.expression_return expression98 = default(TigerParser.expression_return);
		TigerParser.expression_return expression100 = default(TigerParser.expression_return);

		CommonTree SEMICOLON99_tree=null;
		RewriteRuleITokenStream stream_SEMICOLON=new RewriteRuleITokenStream(adaptor,"token SEMICOLON");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expr_seq");
		DebugLocation(400, 19);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:401:2: ( expression ( SEMICOLON expression )* -> ( expression )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:401:4: expression ( SEMICOLON expression )*
			{
			DebugLocation(401, 4);
			PushFollow(Follow._expression_in_expr_seq2310);
			expression98=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression98.Tree);
			DebugLocation(401, 16);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:401:16: ( SEMICOLON expression )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==SEMICOLON))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:401:17: SEMICOLON expression
					{
					DebugLocation(401, 17);
					SEMICOLON99=(IToken)Match(input,SEMICOLON,Follow._SEMICOLON_in_expr_seq2314); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_SEMICOLON.Add(SEMICOLON99);

					DebugLocation(401, 28);
					PushFollow(Follow._expression_in_expr_seq2317);
					expression100=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression100.Tree);

					}
					break;

				default:
					goto loop23;
				}
			}

			loop23:
				;

			} finally { DebugExitSubRule(23); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 402:2: -> ( expression )+
			{
				DebugLocation(402, 7);
				if ( !(stream_expression.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_expression.HasNext )
				{
					DebugLocation(402, 7);
					adaptor.AddChild(root_0, stream_expression.NextTree());

				}
				stream_expression.Reset();

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_seq", 36);
			LeaveRule("expr_seq", 36);
			Leave_expr_seq();
		}
		DebugLocation(402, 19);
		} finally { DebugExitRule(GrammarFileName, "expr_seq"); }
		return retval;

	}
	// $ANTLR end "expr_seq"

	public class declaration_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration_list();
	partial void Leave_declaration_list();

	// $ANTLR start "declaration_list"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:419:1: declaration_list : ( block_declaration )+ -> ^( DECLARATION_LIST_NODE ( block_declaration )+ ) ;
	[GrammarRule("declaration_list")]
	private TigerParser.declaration_list_return declaration_list()
	{
		Enter_declaration_list();
		EnterRule("declaration_list", 37);
		TraceIn("declaration_list", 37);
		TigerParser.declaration_list_return retval = new TigerParser.declaration_list_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.block_declaration_return block_declaration101 = default(TigerParser.block_declaration_return);

		RewriteRuleSubtreeStream stream_block_declaration=new RewriteRuleSubtreeStream(adaptor,"rule block_declaration");
		try { DebugEnterRule(GrammarFileName, "declaration_list");
		DebugLocation(419, 49);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:420:2: ( ( block_declaration )+ -> ^( DECLARATION_LIST_NODE ( block_declaration )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:420:4: ( block_declaration )+
			{
			DebugLocation(420, 4);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:420:4: ( block_declaration )+
			int cnt24=0;
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==KW_FUNCTION||(LA24_0>=KW_TYPE && LA24_0<=KW_VAR)))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch (alt24)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:420:4: block_declaration
					{
					DebugLocation(420, 4);
					PushFollow(Follow._block_declaration_in_declaration_list2355);
					block_declaration101=block_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_block_declaration.Add(block_declaration101.Tree);

					}
					break;

				default:
					if (cnt24 >= 1)
						goto loop24;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee24 = new EarlyExitException( 24, input );
					DebugRecognitionException(eee24);
					throw eee24;
				}
				cnt24++;
			}
			loop24:
				;

			} finally { DebugExitSubRule(24); }



			{
			// AST REWRITE
			// elements: block_declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 421:2: -> ^( DECLARATION_LIST_NODE ( block_declaration )+ )
			{
				DebugLocation(421, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:421:5: ^( DECLARATION_LIST_NODE ( block_declaration )+ )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(421, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DECLARATION_LIST_NODE, "DECLARATION_LIST_NODE"), root_1);

				DebugLocation(421, 31);
				if ( !(stream_block_declaration.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_block_declaration.HasNext )
				{
					DebugLocation(421, 31);
					adaptor.AddChild(root_1, stream_block_declaration.NextTree());

				}
				stream_block_declaration.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declaration_list", 37);
			LeaveRule("declaration_list", 37);
			Leave_declaration_list();
		}
		DebugLocation(421, 49);
		} finally { DebugExitRule(GrammarFileName, "declaration_list"); }
		return retval;

	}
	// $ANTLR end "declaration_list"

	public class block_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block_declaration();
	partial void Leave_block_declaration();

	// $ANTLR start "block_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:423:1: block_declaration : ( block_type_declaration | block_var_declaration | block_func_declaration );
	[GrammarRule("block_declaration")]
	private TigerParser.block_declaration_return block_declaration()
	{
		Enter_block_declaration();
		EnterRule("block_declaration", 38);
		TraceIn("block_declaration", 38);
		TigerParser.block_declaration_return retval = new TigerParser.block_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.block_type_declaration_return block_type_declaration102 = default(TigerParser.block_type_declaration_return);
		TigerParser.block_var_declaration_return block_var_declaration103 = default(TigerParser.block_var_declaration_return);
		TigerParser.block_func_declaration_return block_func_declaration104 = default(TigerParser.block_func_declaration_return);


		try { DebugEnterRule(GrammarFileName, "block_declaration");
		DebugLocation(423, 1);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:424:2: ( block_type_declaration | block_var_declaration | block_func_declaration )
			int alt25=3;
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			switch (input.LA(1))
			{
			case KW_TYPE:
				{
				alt25=1;
				}
				break;
			case KW_VAR:
				{
				alt25=2;
				}
				break;
			case KW_FUNCTION:
				{
				alt25=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:424:4: block_type_declaration
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(424, 4);
				PushFollow(Follow._block_type_declaration_in_block_declaration2378);
				block_type_declaration102=block_type_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_type_declaration102.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:425:4: block_var_declaration
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(425, 4);
				PushFollow(Follow._block_var_declaration_in_block_declaration2383);
				block_var_declaration103=block_var_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_var_declaration103.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:426:4: block_func_declaration
				{
				root_0 = (CommonTree)adaptor.Nil();

				DebugLocation(426, 4);
				PushFollow(Follow._block_func_declaration_in_block_declaration2388);
				block_func_declaration104=block_func_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_func_declaration104.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block_declaration", 38);
			LeaveRule("block_declaration", 38);
			Leave_block_declaration();
		}
		DebugLocation(427, 1);
		} finally { DebugExitRule(GrammarFileName, "block_declaration"); }
		return retval;

	}
	// $ANTLR end "block_declaration"

	public class block_type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block_type_declaration();
	partial void Leave_block_type_declaration();

	// $ANTLR start "block_type_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:429:1: block_type_declaration : ( type_declaration )+ -> ^( BLOCK_TYPE_DECL ( type_declaration )+ ) ;
	[GrammarRule("block_type_declaration")]
	private TigerParser.block_type_declaration_return block_type_declaration()
	{
		Enter_block_type_declaration();
		EnterRule("block_type_declaration", 39);
		TraceIn("block_type_declaration", 39);
		TigerParser.block_type_declaration_return retval = new TigerParser.block_type_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.type_declaration_return type_declaration105 = default(TigerParser.type_declaration_return);

		RewriteRuleSubtreeStream stream_type_declaration=new RewriteRuleSubtreeStream(adaptor,"rule type_declaration");
		try { DebugEnterRule(GrammarFileName, "block_type_declaration");
		DebugLocation(429, 39);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:430:2: ( ( type_declaration )+ -> ^( BLOCK_TYPE_DECL ( type_declaration )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:430:4: ( type_declaration )+
			{
			DebugLocation(430, 4);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:430:4: ( type_declaration )+
			int cnt26=0;
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==KW_TYPE))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch (alt26)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:430:4: type_declaration
					{
					DebugLocation(430, 4);
					PushFollow(Follow._type_declaration_in_block_type_declaration2401);
					type_declaration105=type_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_declaration.Add(type_declaration105.Tree);

					}
					break;

				default:
					if (cnt26 >= 1)
						goto loop26;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee26 = new EarlyExitException( 26, input );
					DebugRecognitionException(eee26);
					throw eee26;
				}
				cnt26++;
			}
			loop26:
				;

			} finally { DebugExitSubRule(26); }



			{
			// AST REWRITE
			// elements: type_declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 431:2: -> ^( BLOCK_TYPE_DECL ( type_declaration )+ )
			{
				DebugLocation(431, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:431:4: ^( BLOCK_TYPE_DECL ( type_declaration )+ )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(431, 6);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK_TYPE_DECL, "BLOCK_TYPE_DECL"), root_1);

				DebugLocation(431, 22);
				if ( !(stream_type_declaration.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_type_declaration.HasNext )
				{
					DebugLocation(431, 22);
					adaptor.AddChild(root_1, stream_type_declaration.NextTree());

				}
				stream_type_declaration.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block_type_declaration", 39);
			LeaveRule("block_type_declaration", 39);
			Leave_block_type_declaration();
		}
		DebugLocation(431, 39);
		} finally { DebugExitRule(GrammarFileName, "block_type_declaration"); }
		return retval;

	}
	// $ANTLR end "block_type_declaration"

	public class block_var_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block_var_declaration();
	partial void Leave_block_var_declaration();

	// $ANTLR start "block_var_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:433:1: block_var_declaration : ( var_declaration )+ -> ^( BLOCK_VAR_DECL ( var_declaration )+ ) ;
	[GrammarRule("block_var_declaration")]
	private TigerParser.block_var_declaration_return block_var_declaration()
	{
		Enter_block_var_declaration();
		EnterRule("block_var_declaration", 40);
		TraceIn("block_var_declaration", 40);
		TigerParser.block_var_declaration_return retval = new TigerParser.block_var_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.var_declaration_return var_declaration106 = default(TigerParser.var_declaration_return);

		RewriteRuleSubtreeStream stream_var_declaration=new RewriteRuleSubtreeStream(adaptor,"rule var_declaration");
		try { DebugEnterRule(GrammarFileName, "block_var_declaration");
		DebugLocation(433, 37);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:434:2: ( ( var_declaration )+ -> ^( BLOCK_VAR_DECL ( var_declaration )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:434:4: ( var_declaration )+
			{
			DebugLocation(434, 4);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:434:4: ( var_declaration )+
			int cnt27=0;
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==KW_VAR))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch (alt27)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:434:4: var_declaration
					{
					DebugLocation(434, 4);
					PushFollow(Follow._var_declaration_in_block_var_declaration2422);
					var_declaration106=var_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_var_declaration.Add(var_declaration106.Tree);

					}
					break;

				default:
					if (cnt27 >= 1)
						goto loop27;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee27 = new EarlyExitException( 27, input );
					DebugRecognitionException(eee27);
					throw eee27;
				}
				cnt27++;
			}
			loop27:
				;

			} finally { DebugExitSubRule(27); }



			{
			// AST REWRITE
			// elements: var_declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 435:2: -> ^( BLOCK_VAR_DECL ( var_declaration )+ )
			{
				DebugLocation(435, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:435:4: ^( BLOCK_VAR_DECL ( var_declaration )+ )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(435, 6);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK_VAR_DECL, "BLOCK_VAR_DECL"), root_1);

				DebugLocation(435, 21);
				if ( !(stream_var_declaration.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_var_declaration.HasNext )
				{
					DebugLocation(435, 21);
					adaptor.AddChild(root_1, stream_var_declaration.NextTree());

				}
				stream_var_declaration.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block_var_declaration", 40);
			LeaveRule("block_var_declaration", 40);
			Leave_block_var_declaration();
		}
		DebugLocation(435, 37);
		} finally { DebugExitRule(GrammarFileName, "block_var_declaration"); }
		return retval;

	}
	// $ANTLR end "block_var_declaration"

	public class block_func_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_block_func_declaration();
	partial void Leave_block_func_declaration();

	// $ANTLR start "block_func_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:437:1: block_func_declaration : ( function_declaration )+ -> ^( BLOCK_FUNC_DECL ( function_declaration )+ ) ;
	[GrammarRule("block_func_declaration")]
	private TigerParser.block_func_declaration_return block_func_declaration()
	{
		Enter_block_func_declaration();
		EnterRule("block_func_declaration", 41);
		TraceIn("block_func_declaration", 41);
		TigerParser.block_func_declaration_return retval = new TigerParser.block_func_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		TigerParser.function_declaration_return function_declaration107 = default(TigerParser.function_declaration_return);

		RewriteRuleSubtreeStream stream_function_declaration=new RewriteRuleSubtreeStream(adaptor,"rule function_declaration");
		try { DebugEnterRule(GrammarFileName, "block_func_declaration");
		DebugLocation(437, 43);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:438:2: ( ( function_declaration )+ -> ^( BLOCK_FUNC_DECL ( function_declaration )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:438:4: ( function_declaration )+
			{
			DebugLocation(438, 4);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:438:4: ( function_declaration )+
			int cnt28=0;
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==KW_FUNCTION))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch (alt28)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:438:4: function_declaration
					{
					DebugLocation(438, 4);
					PushFollow(Follow._function_declaration_in_block_func_declaration2442);
					function_declaration107=function_declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_function_declaration.Add(function_declaration107.Tree);

					}
					break;

				default:
					if (cnt28 >= 1)
						goto loop28;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee28 = new EarlyExitException( 28, input );
					DebugRecognitionException(eee28);
					throw eee28;
				}
				cnt28++;
			}
			loop28:
				;

			} finally { DebugExitSubRule(28); }



			{
			// AST REWRITE
			// elements: function_declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 439:2: -> ^( BLOCK_FUNC_DECL ( function_declaration )+ )
			{
				DebugLocation(439, 4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:439:4: ^( BLOCK_FUNC_DECL ( function_declaration )+ )
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(439, 6);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BLOCK_FUNC_DECL, "BLOCK_FUNC_DECL"), root_1);

				DebugLocation(439, 22);
				if ( !(stream_function_declaration.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_function_declaration.HasNext )
				{
					DebugLocation(439, 22);
					adaptor.AddChild(root_1, stream_function_declaration.NextTree());

				}
				stream_function_declaration.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("block_func_declaration", 41);
			LeaveRule("block_func_declaration", 41);
			Leave_block_func_declaration();
		}
		DebugLocation(439, 43);
		} finally { DebugExitRule(GrammarFileName, "block_func_declaration"); }
		return retval;

	}
	// $ANTLR end "block_func_declaration"

	public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_declaration();
	partial void Leave_type_declaration();

	// $ANTLR start "type_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:443:1: type_declaration : KW_TYPE new_type= IDENTIFIER EQUAL_OP (alias_id= IDENTIFIER -> ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id) | OPEN_BRACE ( type_fields )? CLOSE_BRACE -> ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) ) | KW_ARRAY KW_OF type_items= IDENTIFIER -> ^( ARRAY_TYPE_DEC_NODE $new_type $type_items) ) ;
	[GrammarRule("type_declaration")]
	private TigerParser.type_declaration_return type_declaration()
	{
		Enter_type_declaration();
		EnterRule("type_declaration", 42);
		TraceIn("type_declaration", 42);
		TigerParser.type_declaration_return retval = new TigerParser.type_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken new_type=null;
		IToken alias_id=null;
		IToken type_items=null;
		IToken KW_TYPE108=null;
		IToken EQUAL_OP109=null;
		IToken OPEN_BRACE110=null;
		IToken CLOSE_BRACE112=null;
		IToken KW_ARRAY113=null;
		IToken KW_OF114=null;
		TigerParser.type_fields_return type_fields111 = default(TigerParser.type_fields_return);

		CommonTree new_type_tree=null;
		CommonTree alias_id_tree=null;
		CommonTree type_items_tree=null;
		CommonTree KW_TYPE108_tree=null;
		CommonTree EQUAL_OP109_tree=null;
		CommonTree OPEN_BRACE110_tree=null;
		CommonTree CLOSE_BRACE112_tree=null;
		CommonTree KW_ARRAY113_tree=null;
		CommonTree KW_OF114_tree=null;
		RewriteRuleITokenStream stream_KW_TYPE=new RewriteRuleITokenStream(adaptor,"token KW_TYPE");
		RewriteRuleITokenStream stream_KW_OF=new RewriteRuleITokenStream(adaptor,"token KW_OF");
		RewriteRuleITokenStream stream_CLOSE_BRACE=new RewriteRuleITokenStream(adaptor,"token CLOSE_BRACE");
		RewriteRuleITokenStream stream_KW_ARRAY=new RewriteRuleITokenStream(adaptor,"token KW_ARRAY");
		RewriteRuleITokenStream stream_OPEN_BRACE=new RewriteRuleITokenStream(adaptor,"token OPEN_BRACE");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_EQUAL_OP=new RewriteRuleITokenStream(adaptor,"token EQUAL_OP");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		try { DebugEnterRule(GrammarFileName, "type_declaration");
		DebugLocation(443, 2);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:444:2: ( KW_TYPE new_type= IDENTIFIER EQUAL_OP (alias_id= IDENTIFIER -> ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id) | OPEN_BRACE ( type_fields )? CLOSE_BRACE -> ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) ) | KW_ARRAY KW_OF type_items= IDENTIFIER -> ^( ARRAY_TYPE_DEC_NODE $new_type $type_items) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:444:4: KW_TYPE new_type= IDENTIFIER EQUAL_OP (alias_id= IDENTIFIER -> ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id) | OPEN_BRACE ( type_fields )? CLOSE_BRACE -> ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) ) | KW_ARRAY KW_OF type_items= IDENTIFIER -> ^( ARRAY_TYPE_DEC_NODE $new_type $type_items) )
			{
			DebugLocation(444, 4);
			KW_TYPE108=(IToken)Match(input,KW_TYPE,Follow._KW_TYPE_in_type_declaration2465); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_TYPE.Add(KW_TYPE108);

			DebugLocation(444, 22);
			new_type=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_type_declaration2472); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(new_type);

			DebugLocation(444, 37);
			EQUAL_OP109=(IToken)Match(input,EQUAL_OP,Follow._EQUAL_OP_in_type_declaration2476); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EQUAL_OP.Add(EQUAL_OP109);

			DebugLocation(445, 2);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:445:2: (alias_id= IDENTIFIER -> ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id) | OPEN_BRACE ( type_fields )? CLOSE_BRACE -> ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) ) | KW_ARRAY KW_OF type_items= IDENTIFIER -> ^( ARRAY_TYPE_DEC_NODE $new_type $type_items) )
			int alt30=3;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			switch (input.LA(1))
			{
			case IDENTIFIER:
				{
				alt30=1;
				}
				break;
			case OPEN_BRACE:
				{
				alt30=2;
				}
				break;
			case KW_ARRAY:
				{
				alt30=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 30, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:445:4: alias_id= IDENTIFIER
				{
				DebugLocation(445, 13);
				alias_id=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_type_declaration2488); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(alias_id);



				{
				// AST REWRITE
				// elements: alias_id, new_type
				// token labels: new_type, alias_id
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_new_type=new RewriteRuleITokenStream(adaptor,"token new_type",new_type);
				RewriteRuleITokenStream stream_alias_id=new RewriteRuleITokenStream(adaptor,"token alias_id",alias_id);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 446:2: -> ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id)
				{
					DebugLocation(446, 6);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:446:6: ^( ALIAS_TYPE_DEC_NODE $new_type $alias_id)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(446, 8);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ALIAS_TYPE_DEC_NODE, "ALIAS_TYPE_DEC_NODE"), root_1);

					DebugLocation(446, 30);
					adaptor.AddChild(root_1, stream_new_type.NextNode());
					DebugLocation(446, 42);
					adaptor.AddChild(root_1, stream_alias_id.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:448:2: OPEN_BRACE ( type_fields )? CLOSE_BRACE
				{
				DebugLocation(448, 2);
				OPEN_BRACE110=(IToken)Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_type_declaration2515); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OPEN_BRACE.Add(OPEN_BRACE110);

				DebugLocation(448, 17);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:448:17: ( type_fields )?
				int alt29=2;
				try { DebugEnterSubRule(29);
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==IDENTIFIER))
				{
					alt29=1;
				}
				} finally { DebugExitDecision(29); }
				switch (alt29)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:448:17: type_fields
					{
					DebugLocation(448, 17);
					PushFollow(Follow._type_fields_in_type_declaration2521);
					type_fields111=type_fields();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_fields.Add(type_fields111.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(29); }

				DebugLocation(448, 33);
				CLOSE_BRACE112=(IToken)Match(input,CLOSE_BRACE,Follow._CLOSE_BRACE_in_type_declaration2527); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CLOSE_BRACE.Add(CLOSE_BRACE112);



				{
				// AST REWRITE
				// elements: type_fields, new_type
				// token labels: new_type
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_new_type=new RewriteRuleITokenStream(adaptor,"token new_type",new_type);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 449:2: -> ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) )
				{
					DebugLocation(449, 6);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:449:6: ^( RECORD_TYPE_DEC_NODE $new_type ^( FIELDS_RECORD ( type_fields )? ) )
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(449, 8);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RECORD_TYPE_DEC_NODE, "RECORD_TYPE_DEC_NODE"), root_1);

					DebugLocation(449, 31);
					adaptor.AddChild(root_1, stream_new_type.NextNode());
					DebugLocation(449, 43);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:449:43: ^( FIELDS_RECORD ( type_fields )? )
					{
					CommonTree root_2 = (CommonTree)adaptor.Nil();
					DebugLocation(449, 45);
					root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FIELDS_RECORD, "FIELDS_RECORD"), root_2);

					DebugLocation(449, 60);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:449:60: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(449, 60);
						adaptor.AddChild(root_2, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:451:2: KW_ARRAY KW_OF type_items= IDENTIFIER
				{
				DebugLocation(451, 2);
				KW_ARRAY113=(IToken)Match(input,KW_ARRAY,Follow._KW_ARRAY_in_type_declaration2558); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_KW_ARRAY.Add(KW_ARRAY113);

				DebugLocation(451, 13);
				KW_OF114=(IToken)Match(input,KW_OF,Follow._KW_OF_in_type_declaration2562); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_KW_OF.Add(KW_OF114);

				DebugLocation(451, 32);
				type_items=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_type_declaration2570); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(type_items);



				{
				// AST REWRITE
				// elements: new_type, type_items
				// token labels: new_type, type_items
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_new_type=new RewriteRuleITokenStream(adaptor,"token new_type",new_type);
				RewriteRuleITokenStream stream_type_items=new RewriteRuleITokenStream(adaptor,"token type_items",type_items);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 452:2: -> ^( ARRAY_TYPE_DEC_NODE $new_type $type_items)
				{
					DebugLocation(452, 6);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:452:6: ^( ARRAY_TYPE_DEC_NODE $new_type $type_items)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(452, 8);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ARRAY_TYPE_DEC_NODE, "ARRAY_TYPE_DEC_NODE"), root_1);

					DebugLocation(452, 30);
					adaptor.AddChild(root_1, stream_new_type.NextNode());
					DebugLocation(452, 42);
					adaptor.AddChild(root_1, stream_type_items.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(30); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_declaration", 42);
			LeaveRule("type_declaration", 42);
			Leave_type_declaration();
		}
		DebugLocation(453, 2);
		} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
		return retval;

	}
	// $ANTLR end "type_declaration"

	public class var_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_var_declaration();
	partial void Leave_var_declaration();

	// $ANTLR start "var_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:459:1: var_declaration : KW_VAR name= IDENTIFIER ( ASSIGN_OP value= expression -> ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value) | COLON type= IDENTIFIER ASSIGN_OP value= expression -> ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type) ) ;
	[GrammarRule("var_declaration")]
	private TigerParser.var_declaration_return var_declaration()
	{
		Enter_var_declaration();
		EnterRule("var_declaration", 43);
		TraceIn("var_declaration", 43);
		TigerParser.var_declaration_return retval = new TigerParser.var_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name=null;
		IToken type=null;
		IToken KW_VAR115=null;
		IToken ASSIGN_OP116=null;
		IToken COLON117=null;
		IToken ASSIGN_OP118=null;
		TigerParser.expression_return value = default(TigerParser.expression_return);

		CommonTree name_tree=null;
		CommonTree type_tree=null;
		CommonTree KW_VAR115_tree=null;
		CommonTree ASSIGN_OP116_tree=null;
		CommonTree COLON117_tree=null;
		CommonTree ASSIGN_OP118_tree=null;
		RewriteRuleITokenStream stream_ASSIGN_OP=new RewriteRuleITokenStream(adaptor,"token ASSIGN_OP");
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_KW_VAR=new RewriteRuleITokenStream(adaptor,"token KW_VAR");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "var_declaration");
		DebugLocation(459, 2);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:460:2: ( KW_VAR name= IDENTIFIER ( ASSIGN_OP value= expression -> ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value) | COLON type= IDENTIFIER ASSIGN_OP value= expression -> ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:460:3: KW_VAR name= IDENTIFIER ( ASSIGN_OP value= expression -> ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value) | COLON type= IDENTIFIER ASSIGN_OP value= expression -> ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type) )
			{
			DebugLocation(460, 3);
			KW_VAR115=(IToken)Match(input,KW_VAR,Follow._KW_VAR_in_var_declaration2604); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_VAR.Add(KW_VAR115);

			DebugLocation(460, 19);
			name=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_var_declaration2614); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name);

			DebugLocation(461, 2);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:461:2: ( ASSIGN_OP value= expression -> ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value) | COLON type= IDENTIFIER ASSIGN_OP value= expression -> ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type) )
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==ASSIGN_OP))
			{
				alt31=1;
			}
			else if ((LA31_0==COLON))
			{
				alt31=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:462:2: ASSIGN_OP value= expression
				{
				DebugLocation(462, 2);
				ASSIGN_OP116=(IToken)Match(input,ASSIGN_OP,Follow._ASSIGN_OP_in_var_declaration2622); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN_OP.Add(ASSIGN_OP116);

				DebugLocation(462, 20);
				PushFollow(Follow._expression_in_var_declaration2630);
				value=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(value.Tree);


				{
				// AST REWRITE
				// elements: name, value
				// token labels: name
				// rule labels: retval, value
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value",value!=null?value.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 463:2: -> ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value)
				{
					DebugLocation(463, 5);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:463:5: ^( INFERENCED_TYPE_VAR_DEC_NODE $name $value)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(463, 7);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(INFERENCED_TYPE_VAR_DEC_NODE, "INFERENCED_TYPE_VAR_DEC_NODE"), root_1);

					DebugLocation(463, 39);
					adaptor.AddChild(root_1, stream_name.NextNode());
					DebugLocation(463, 48);
					adaptor.AddChild(root_1, stream_value.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:465:2: COLON type= IDENTIFIER ASSIGN_OP value= expression
				{
				DebugLocation(465, 2);
				COLON117=(IToken)Match(input,COLON,Follow._COLON_in_var_declaration2656); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON117);

				DebugLocation(465, 18);
				type=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_var_declaration2667); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(type);

				DebugLocation(465, 36);
				ASSIGN_OP118=(IToken)Match(input,ASSIGN_OP,Follow._ASSIGN_OP_in_var_declaration2674); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN_OP.Add(ASSIGN_OP118);

				DebugLocation(465, 56);
				PushFollow(Follow._expression_in_var_declaration2684);
				value=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(value.Tree);


				{
				// AST REWRITE
				// elements: name, type, value
				// token labels: name, type
				// rule labels: retval, value
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_name=new RewriteRuleITokenStream(adaptor,"token name",name);
				RewriteRuleITokenStream stream_type=new RewriteRuleITokenStream(adaptor,"token type",type);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_value=new RewriteRuleSubtreeStream(adaptor,"rule value",value!=null?value.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 466:2: -> ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type)
				{
					DebugLocation(466, 5);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:466:5: ^( DEFINED_TYPE_VAR_DEC_NODE $name $value $type)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(466, 7);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DEFINED_TYPE_VAR_DEC_NODE, "DEFINED_TYPE_VAR_DEC_NODE"), root_1);

					DebugLocation(466, 36);
					adaptor.AddChild(root_1, stream_name.NextNode());
					DebugLocation(466, 45);
					adaptor.AddChild(root_1, stream_value.NextTree());
					DebugLocation(466, 56);
					adaptor.AddChild(root_1, stream_type.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(31); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("var_declaration", 43);
			LeaveRule("var_declaration", 43);
			Leave_var_declaration();
		}
		DebugLocation(467, 2);
		} finally { DebugExitRule(GrammarFileName, "var_declaration"); }
		return retval;

	}
	// $ANTLR end "var_declaration"

	public class function_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_function_declaration();
	partial void Leave_function_declaration();

	// $ANTLR start "function_declaration"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:473:1: function_declaration : KW_FUNCTION name_function= IDENTIFIER OPEN_PARENTHESIS ( type_fields )? CLOSE_PARENTHESIS ( COLON type_return= IDENTIFIER EQUAL_OP body= expression -> ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return) | EQUAL_OP body= expression -> ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body) ) ;
	[GrammarRule("function_declaration")]
	private TigerParser.function_declaration_return function_declaration()
	{
		Enter_function_declaration();
		EnterRule("function_declaration", 44);
		TraceIn("function_declaration", 44);
		TigerParser.function_declaration_return retval = new TigerParser.function_declaration_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name_function=null;
		IToken type_return=null;
		IToken KW_FUNCTION119=null;
		IToken OPEN_PARENTHESIS120=null;
		IToken CLOSE_PARENTHESIS122=null;
		IToken COLON123=null;
		IToken EQUAL_OP124=null;
		IToken EQUAL_OP125=null;
		TigerParser.expression_return body = default(TigerParser.expression_return);
		TigerParser.type_fields_return type_fields121 = default(TigerParser.type_fields_return);

		CommonTree name_function_tree=null;
		CommonTree type_return_tree=null;
		CommonTree KW_FUNCTION119_tree=null;
		CommonTree OPEN_PARENTHESIS120_tree=null;
		CommonTree CLOSE_PARENTHESIS122_tree=null;
		CommonTree COLON123_tree=null;
		CommonTree EQUAL_OP124_tree=null;
		CommonTree EQUAL_OP125_tree=null;
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_KW_FUNCTION=new RewriteRuleITokenStream(adaptor,"token KW_FUNCTION");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");
		RewriteRuleITokenStream stream_OPEN_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token OPEN_PARENTHESIS");
		RewriteRuleITokenStream stream_CLOSE_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token CLOSE_PARENTHESIS");
		RewriteRuleITokenStream stream_EQUAL_OP=new RewriteRuleITokenStream(adaptor,"token EQUAL_OP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		try { DebugEnterRule(GrammarFileName, "function_declaration");
		DebugLocation(473, 2);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:474:2: ( KW_FUNCTION name_function= IDENTIFIER OPEN_PARENTHESIS ( type_fields )? CLOSE_PARENTHESIS ( COLON type_return= IDENTIFIER EQUAL_OP body= expression -> ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return) | EQUAL_OP body= expression -> ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body) ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:474:3: KW_FUNCTION name_function= IDENTIFIER OPEN_PARENTHESIS ( type_fields )? CLOSE_PARENTHESIS ( COLON type_return= IDENTIFIER EQUAL_OP body= expression -> ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return) | EQUAL_OP body= expression -> ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body) )
			{
			DebugLocation(474, 3);
			KW_FUNCTION119=(IToken)Match(input,KW_FUNCTION,Follow._KW_FUNCTION_in_function_declaration2739); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_KW_FUNCTION.Add(KW_FUNCTION119);

			DebugLocation(474, 31);
			name_function=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_function_declaration2747); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name_function);

			DebugLocation(474, 46);
			OPEN_PARENTHESIS120=(IToken)Match(input,OPEN_PARENTHESIS,Follow._OPEN_PARENTHESIS_in_function_declaration2751); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OPEN_PARENTHESIS.Add(OPEN_PARENTHESIS120);

			DebugLocation(474, 65);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:474:65: ( type_fields )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==IDENTIFIER))
			{
				alt32=1;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:474:65: type_fields
				{
				DebugLocation(474, 65);
				PushFollow(Follow._type_fields_in_function_declaration2755);
				type_fields121=type_fields();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_fields.Add(type_fields121.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(32); }

			DebugLocation(474, 79);
			CLOSE_PARENTHESIS122=(IToken)Match(input,CLOSE_PARENTHESIS,Follow._CLOSE_PARENTHESIS_in_function_declaration2759); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CLOSE_PARENTHESIS.Add(CLOSE_PARENTHESIS122);

			DebugLocation(475, 2);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:475:2: ( COLON type_return= IDENTIFIER EQUAL_OP body= expression -> ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return) | EQUAL_OP body= expression -> ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body) )
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==COLON))
			{
				alt33=1;
			}
			else if ((LA33_0==EQUAL_OP))
			{
				alt33=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:476:2: COLON type_return= IDENTIFIER EQUAL_OP body= expression
				{
				DebugLocation(476, 2);
				COLON123=(IToken)Match(input,COLON,Follow._COLON_in_function_declaration2767); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON123);

				DebugLocation(476, 22);
				type_return=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_function_declaration2775); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(type_return);

				DebugLocation(476, 37);
				EQUAL_OP124=(IToken)Match(input,EQUAL_OP,Follow._EQUAL_OP_in_function_declaration2779); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL_OP.Add(EQUAL_OP124);

				DebugLocation(476, 52);
				PushFollow(Follow._expression_in_function_declaration2787);
				body=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(body.Tree);


				{
				// AST REWRITE
				// elements: body, name_function, type_return, type_fields
				// token labels: type_return, name_function
				// rule labels: body, retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_type_return=new RewriteRuleITokenStream(adaptor,"token type_return",type_return);
				RewriteRuleITokenStream stream_name_function=new RewriteRuleITokenStream(adaptor,"token name_function",name_function);
				RewriteRuleSubtreeStream stream_body=new RewriteRuleSubtreeStream(adaptor,"rule body",body!=null?body.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 477:2: -> ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return)
				{
					DebugLocation(477, 5);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:477:5: ^( FUNCTION_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body $type_return)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(477, 7);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION_DECLARATION_NODE, "FUNCTION_DECLARATION_NODE"), root_1);

					DebugLocation(477, 36);
					adaptor.AddChild(root_1, stream_name_function.NextNode());
					DebugLocation(477, 54);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:477:54: ^( PARAMETERS_DEC ( type_fields )? )
					{
					CommonTree root_2 = (CommonTree)adaptor.Nil();
					DebugLocation(477, 56);
					root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAMETERS_DEC, "PARAMETERS_DEC"), root_2);

					DebugLocation(477, 74);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:477:74: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(477, 74);
						adaptor.AddChild(root_2, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(477, 91);
					adaptor.AddChild(root_1, stream_body.NextTree());
					DebugLocation(477, 100);
					adaptor.AddChild(root_1, stream_type_return.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:479:2: EQUAL_OP body= expression
				{
				DebugLocation(479, 2);
				EQUAL_OP125=(IToken)Match(input,EQUAL_OP,Follow._EQUAL_OP_in_function_declaration2831); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL_OP.Add(EQUAL_OP125);

				DebugLocation(479, 17);
				PushFollow(Follow._expression_in_function_declaration2838);
				body=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(body.Tree);


				{
				// AST REWRITE
				// elements: name_function, body, type_fields
				// token labels: name_function
				// rule labels: body, retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_name_function=new RewriteRuleITokenStream(adaptor,"token name_function",name_function);
				RewriteRuleSubtreeStream stream_body=new RewriteRuleSubtreeStream(adaptor,"rule body",body!=null?body.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (CommonTree)adaptor.Nil();
				// 480:2: -> ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body)
				{
					DebugLocation(480, 5);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:480:5: ^( PROCEDURE_DECLARATION_NODE $name_function ^( PARAMETERS_DEC ( type_fields )? ) $body)
					{
					CommonTree root_1 = (CommonTree)adaptor.Nil();
					DebugLocation(480, 7);
					root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROCEDURE_DECLARATION_NODE, "PROCEDURE_DECLARATION_NODE"), root_1);

					DebugLocation(480, 37);
					adaptor.AddChild(root_1, stream_name_function.NextNode());
					DebugLocation(480, 55);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:480:55: ^( PARAMETERS_DEC ( type_fields )? )
					{
					CommonTree root_2 = (CommonTree)adaptor.Nil();
					DebugLocation(480, 57);
					root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAMETERS_DEC, "PARAMETERS_DEC"), root_2);

					DebugLocation(480, 75);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:480:75: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(480, 75);
						adaptor.AddChild(root_2, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(480, 92);
					adaptor.AddChild(root_1, stream_body.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(33); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("function_declaration", 44);
			LeaveRule("function_declaration", 44);
			Leave_function_declaration();
		}
		DebugLocation(481, 2);
		} finally { DebugExitRule(GrammarFileName, "function_declaration"); }
		return retval;

	}
	// $ANTLR end "function_declaration"

	public class type_fields_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_fields();
	partial void Leave_type_fields();

	// $ANTLR start "type_fields"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:485:1: type_fields : type_field ( COMMA type_field )* -> ( type_field )+ ;
	[GrammarRule("type_fields")]
	private TigerParser.type_fields_return type_fields()
	{
		Enter_type_fields();
		EnterRule("type_fields", 45);
		TraceIn("type_fields", 45);
		TigerParser.type_fields_return retval = new TigerParser.type_fields_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken COMMA127=null;
		TigerParser.type_field_return type_field126 = default(TigerParser.type_field_return);
		TigerParser.type_field_return type_field128 = default(TigerParser.type_field_return);

		CommonTree COMMA127_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_type_field=new RewriteRuleSubtreeStream(adaptor,"rule type_field");
		try { DebugEnterRule(GrammarFileName, "type_fields");
		DebugLocation(485, 48);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:486:2: ( type_field ( COMMA type_field )* -> ( type_field )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:486:4: type_field ( COMMA type_field )*
			{
			DebugLocation(486, 4);
			PushFollow(Follow._type_field_in_type_fields2885);
			type_field126=type_field();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type_field.Add(type_field126.Tree);
			DebugLocation(486, 15);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:486:15: ( COMMA type_field )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==COMMA))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:486:16: COMMA type_field
					{
					DebugLocation(486, 16);
					COMMA127=(IToken)Match(input,COMMA,Follow._COMMA_in_type_fields2888); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA127);

					DebugLocation(486, 22);
					PushFollow(Follow._type_field_in_type_fields2890);
					type_field128=type_field();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_field.Add(type_field128.Tree);

					}
					break;

				default:
					goto loop34;
				}
			}

			loop34:
				;

			} finally { DebugExitSubRule(34); }



			{
			// AST REWRITE
			// elements: type_field
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 486:35: -> ( type_field )+
			{
				DebugLocation(486, 38);
				if ( !(stream_type_field.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_type_field.HasNext )
				{
					DebugLocation(486, 38);
					adaptor.AddChild(root_0, stream_type_field.NextTree());

				}
				stream_type_field.Reset();

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_fields", 45);
			LeaveRule("type_fields", 45);
			Leave_type_fields();
		}
		DebugLocation(486, 48);
		} finally { DebugExitRule(GrammarFileName, "type_fields"); }
		return retval;

	}
	// $ANTLR end "type_fields"

	public class type_field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<CommonTree>
	{
		private CommonTree _tree;
		public CommonTree Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_field();
	partial void Leave_type_field();

	// $ANTLR start "type_field"
	// C:\\Users\\Gustavo\\Desktop\\Tiger.g:488:1: type_field : name_id= IDENTIFIER COLON type_id= IDENTIFIER -> ^( FIELD_DECLARATION_NODE $name_id $type_id) ;
	[GrammarRule("type_field")]
	private TigerParser.type_field_return type_field()
	{
		Enter_type_field();
		EnterRule("type_field", 46);
		TraceIn("type_field", 46);
		TigerParser.type_field_return retval = new TigerParser.type_field_return();
		retval.Start = (IToken)input.LT(1);

		CommonTree root_0 = null;

		IToken name_id=null;
		IToken type_id=null;
		IToken COLON129=null;

		CommonTree name_id_tree=null;
		CommonTree type_id_tree=null;
		CommonTree COLON129_tree=null;
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_IDENTIFIER=new RewriteRuleITokenStream(adaptor,"token IDENTIFIER");

		try { DebugEnterRule(GrammarFileName, "type_field");
		DebugLocation(488, 52);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:489:2: (name_id= IDENTIFIER COLON type_id= IDENTIFIER -> ^( FIELD_DECLARATION_NODE $name_id $type_id) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:489:4: name_id= IDENTIFIER COLON type_id= IDENTIFIER
			{
			DebugLocation(489, 12);
			name_id=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_type_field2910); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(name_id);

			DebugLocation(489, 29);
			COLON129=(IToken)Match(input,COLON,Follow._COLON_in_type_field2916); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_COLON.Add(COLON129);

			DebugLocation(489, 48);
			type_id=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_type_field2927); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENTIFIER.Add(type_id);



			{
			// AST REWRITE
			// elements: name_id, type_id
			// token labels: name_id, type_id
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_name_id=new RewriteRuleITokenStream(adaptor,"token name_id",name_id);
			RewriteRuleITokenStream stream_type_id=new RewriteRuleITokenStream(adaptor,"token type_id",type_id);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (CommonTree)adaptor.Nil();
			// 490:2: -> ^( FIELD_DECLARATION_NODE $name_id $type_id)
			{
				DebugLocation(490, 5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:490:5: ^( FIELD_DECLARATION_NODE $name_id $type_id)
				{
				CommonTree root_1 = (CommonTree)adaptor.Nil();
				DebugLocation(490, 7);
				root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FIELD_DECLARATION_NODE, "FIELD_DECLARATION_NODE"), root_1);

				DebugLocation(490, 32);
				adaptor.AddChild(root_1, stream_name_id.NextNode());
				DebugLocation(490, 44);
				adaptor.AddChild(root_1, stream_type_id.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_field", 46);
			LeaveRule("type_field", 46);
			Leave_type_field();
		}
		DebugLocation(490, 52);
		} finally { DebugExitRule(GrammarFileName, "type_field"); }
		return retval;

	}
	// $ANTLR end "type_field"

	partial void Enter_synpred1_Tiger_fragment();
	partial void Leave_synpred1_Tiger_fragment();

	// $ANTLR start synpred1_Tiger
	public void synpred1_Tiger_fragment()
	{
		Enter_synpred1_Tiger_fragment();
		EnterRule("synpred1_Tiger_fragment", 47);
		TraceIn("synpred1_Tiger_fragment", 47);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:255:3: ( IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:255:4: IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF
			{
			DebugLocation(255, 4);
			Match(input,IDENTIFIER,Follow._IDENTIFIER_in_synpred1_Tiger1278); if (state.failed) return;
			DebugLocation(255, 16);
			Match(input,OPEN_BRACKET,Follow._OPEN_BRACKET_in_synpred1_Tiger1281); if (state.failed) return;
			DebugLocation(255, 30);
			PushFollow(Follow._expression_in_synpred1_Tiger1284);
			expression();
			PopFollow();
			if (state.failed) return;
			DebugLocation(255, 42);
			Match(input,CLOSE_BRACKET,Follow._CLOSE_BRACKET_in_synpred1_Tiger1287); if (state.failed) return;
			DebugLocation(255, 56);
			Match(input,KW_OF,Follow._KW_OF_in_synpred1_Tiger1289); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 47);
			LeaveRule("synpred1_Tiger_fragment", 47);
			Leave_synpred1_Tiger_fragment();
		}
	}
	// $ANTLR end synpred1_Tiger

	partial void Enter_synpred2_Tiger_fragment();
	partial void Leave_synpred2_Tiger_fragment();

	// $ANTLR start synpred2_Tiger
	public void synpred2_Tiger_fragment()
	{
		Enter_synpred2_Tiger_fragment();
		EnterRule("synpred2_Tiger_fragment", 48);
		TraceIn("synpred2_Tiger_fragment", 48);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:270:5: ( IDENTIFIER OPEN_BRACE )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:270:6: IDENTIFIER OPEN_BRACE
			{
			DebugLocation(270, 6);
			Match(input,IDENTIFIER,Follow._IDENTIFIER_in_synpred2_Tiger1390); if (state.failed) return;
			DebugLocation(270, 20);
			Match(input,OPEN_BRACE,Follow._OPEN_BRACE_in_synpred2_Tiger1395); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_Tiger_fragment", 48);
			LeaveRule("synpred2_Tiger_fragment", 48);
			Leave_synpred2_Tiger_fragment();
		}
	}
	// $ANTLR end synpred2_Tiger

	partial void Enter_synpred3_Tiger_fragment();
	partial void Leave_synpred3_Tiger_fragment();

	// $ANTLR start synpred3_Tiger
	public void synpred3_Tiger_fragment()
	{
		Enter_synpred3_Tiger_fragment();
		EnterRule("synpred3_Tiger_fragment", 49);
		TraceIn("synpred3_Tiger_fragment", 49);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:271:5: ( IDENTIFIER OPEN_PARENTHESIS )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:271:6: IDENTIFIER OPEN_PARENTHESIS
			{
			DebugLocation(271, 6);
			Match(input,IDENTIFIER,Follow._IDENTIFIER_in_synpred3_Tiger1409); if (state.failed) return;
			DebugLocation(271, 21);
			Match(input,OPEN_PARENTHESIS,Follow._OPEN_PARENTHESIS_in_synpred3_Tiger1415); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_Tiger_fragment", 49);
			LeaveRule("synpred3_Tiger_fragment", 49);
			Leave_synpred3_Tiger_fragment();
		}
	}
	// $ANTLR end synpred3_Tiger

	partial void Enter_synpred4_Tiger_fragment();
	partial void Leave_synpred4_Tiger_fragment();

	// $ANTLR start synpred4_Tiger
	public void synpred4_Tiger_fragment()
	{
		Enter_synpred4_Tiger_fragment();
		EnterRule("synpred4_Tiger_fragment", 50);
		TraceIn("synpred4_Tiger_fragment", 50);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:365:4: ( KW_IF expression KW_THEN expression KW_ELSE )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:365:5: KW_IF expression KW_THEN expression KW_ELSE
			{
			DebugLocation(365, 5);
			Match(input,KW_IF,Follow._KW_IF_in_synpred4_Tiger2003); if (state.failed) return;
			DebugLocation(365, 12);
			PushFollow(Follow._expression_in_synpred4_Tiger2006);
			expression();
			PopFollow();
			if (state.failed) return;
			DebugLocation(365, 24);
			Match(input,KW_THEN,Follow._KW_THEN_in_synpred4_Tiger2009); if (state.failed) return;
			DebugLocation(365, 33);
			PushFollow(Follow._expression_in_synpred4_Tiger2012);
			expression();
			PopFollow();
			if (state.failed) return;
			DebugLocation(365, 45);
			Match(input,KW_ELSE,Follow._KW_ELSE_in_synpred4_Tiger2015); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred4_Tiger_fragment", 50);
			LeaveRule("synpred4_Tiger_fragment", 50);
			Leave_synpred4_Tiger_fragment();
		}
	}
	// $ANTLR end synpred4_Tiger
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA6 dfa6;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa6 = new DFA6( this, SpecialStateTransition6 );
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\xD\xFFFF";
		private const string DFA6_eofS =
			"\xD\xFFFF";
		private const string DFA6_minS =
			"\x1\x5\x3\xFFFF\x1\x0\x8\xFFFF";
		private const string DFA6_maxS =
			"\x1\x54\x3\xFFFF\x1\x0\x8\xFFFF";
		private const string DFA6_acceptS =
			"\x1\xFFFF\x1\x1\x3\xFFFF\x1\x3\x3\xFFFF\x1\x4\x1\x5\x1\x6\x1\x2";
		private const string DFA6_specialS =
			"\x4\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x1\x5\x3\xFFFF\x1\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x9\x1\x1\x5\xFFFF"+
				"\x1\x5\x8\xFFFF\x1\xB\x3\xFFFF\x1\xA\x2B\xFFFF\x1\x4\x2\xFFFF\x1\x1"+
				"\x3\xFFFF\x1\x1",
				"",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
		private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
		private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
		private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
		private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
		private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
		private static readonly short[][] DFA6_transition;

		static DFA6()
		{
			int numStates = DFA6_transitionS.Length;
			DFA6_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
			}
		}

		public DFA6( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 6;
			this.eot = DFA6_eot;
			this.eof = DFA6_eof;
			this.min = DFA6_min;
			this.max = DFA6_max;
			this.accept = DFA6_accept;
			this.special = DFA6_special;
			this.transition = DFA6_transition;
		}

		public override string Description { get { return "254:1: factor : ( constant_type | ( IDENTIFIER OPEN_BRACKET expression CLOSE_BRACKET KW_OF )=> array_creation | flow_control_expr | let_in_expr | MINUS_OP factor -> ^( UNARY_MINUS_OP factor ) | high_acces_assign_expr );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition6(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA6_4 = input.LA(1);


				int index6_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_Tiger_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 11;}


				input.Seek(index6_4);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 6, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expression_in_tiger_program1152 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_tiger_program1154 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _disjunction_expr_in_expression1165 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conjunction_expr_in_disjunction_expr1178 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _OR_OP_in_disjunction_expr1181 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _conjunction_expr_in_disjunction_expr1184 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _relational_expr_in_conjunction_expr1197 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _AND_OP_in_conjunction_expr1200 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _relational_expr_in_conjunction_expr1203 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _arithmetical_expr_in_relational_expr1216 = new BitSet(new ulong[]{0xFC000000002UL});
		public static readonly BitSet _relational_operator_in_relational_expr1219 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _arithmetical_expr_in_relational_expr1222 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_arithmetical_expr1235 = new BitSet(new ulong[]{0x300000002UL});
		public static readonly BitSet _add_operator_in_arithmetical_expr1238 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _term_in_arithmetical_expr1241 = new BitSet(new ulong[]{0x300000002UL});
		public static readonly BitSet _factor_in_term1255 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _product_operator_in_term1258 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _factor_in_term1261 = new BitSet(new ulong[]{0xC00000002UL});
		public static readonly BitSet _constant_type_in_factor1273 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _array_creation_in_factor1295 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _flow_control_expr_in_factor1300 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _let_in_expr_in_factor1305 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_OP_in_factor1310 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _factor_in_factor1313 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _high_acces_assign_expr_in_factor1338 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignable_expr_in_high_acces_assign_expr1351 = new BitSet(new ulong[]{0x80000002UL});
		public static readonly BitSet _assign_expr_in_high_acces_assign_expr1358 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _accessible_expr_in_assignable_expr1370 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _high_acces_in_assignable_expr1376 = new BitSet(new ulong[]{0x8200002UL});
		public static readonly BitSet _record_literal_init_in_accessible_expr1401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_function_expr_in_accessible_expr1422 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_seq_instr_in_accessible_expr1429 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_accessible_expr1435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_lvalue1449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_CONSTANT_in_constant_type1470 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_CONSTANT_in_constant_type1476 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_NIL_in_constant_type1482 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_PARENTHESIS_in_expr_seq_instr1492 = new BitSet(new ulong[]{0x260106A20UL,0x112000UL});
		public static readonly BitSet _expr_seq_in_expr_seq_instr1495 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _CLOSE_PARENTHESIS_in_expr_seq_instr1499 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_OP_in_relational_operator1529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DISTINCT_OP_in_relational_operator1535 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_THAN_OP_in_relational_operator1541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_THAN_EQUAL_OP_in_relational_operator1547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _GREATER_THAN_OP_in_relational_operator1553 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _GREATER_THAN_EQUAL_OP_in_relational_operator1559 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_OP_in_add_operator1572 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_OP_in_add_operator1578 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_OP_in_product_operator1589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIV_OP_in_product_operator1595 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_record_literal_init1613 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _OPEN_BRACE_in_record_literal_init1616 = new BitSet(new ulong[]{0x4000000UL,0x2000UL});
		public static readonly BitSet _field_list_in_record_literal_init1619 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_record_literal_init1623 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _field_assign_in_field_list1655 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_field_list1659 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _field_assign_in_field_list1662 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _IDENTIFIER_in_field_assign1687 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _EQUAL_OP_in_field_assign1692 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_field_assign1701 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_array_creation1730 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _OPEN_BRACKET_in_array_creation1734 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_array_creation1743 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _CLOSE_BRACKET_in_array_creation1748 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _KW_OF_in_array_creation1752 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_array_creation1760 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _subscript_in_high_acces1795 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _field_in_high_acces1800 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACKET_in_subscript1812 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_subscript1819 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _CLOSE_BRACKET_in_subscript1822 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _POINT_in_field1844 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_field1850 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_call_function_expr1882 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OPEN_PARENTHESIS_in_call_function_expr1888 = new BitSet(new ulong[]{0x260106A20UL,0x112000UL});
		public static readonly BitSet _expr_list_in_call_function_expr1893 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _CLOSE_PARENTHESIS_in_call_function_expr1899 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expr_list1931 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_expr_list1935 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_expr_list1938 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _ASSIGN_OP_in_assign_expr1960 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_assign_expr1963 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditional_jump_in_flow_control_expr1976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _while_loop_expr_in_flow_control_expr1981 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _for_loop_expr_in_flow_control_expr1986 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _break_expr_in_flow_control_expr1991 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if_then_else_expr_in_conditional_jump2021 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if_then_expr_in_conditional_jump2027 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_IF_in_if_then_expr2036 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_if_then_expr2042 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _KW_THEN_in_if_then_expr2045 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_if_then_expr2052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_IF_in_if_then_else_expr2079 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_if_then_else_expr2087 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _KW_THEN_in_if_then_else_expr2090 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_if_then_else_expr2098 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _KW_ELSE_in_if_then_else_expr2101 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_if_then_else_expr2110 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_WHILE_in_while_loop_expr2144 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_while_loop_expr2148 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _KW_DO_in_while_loop_expr2152 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_while_loop_expr2157 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_FOR_in_for_loop_expr2168 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_for_loop_expr2176 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _ASSIGN_OP_in_for_loop_expr2180 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_for_loop_expr2188 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _KW_TO_in_for_loop_expr2191 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_for_loop_expr2198 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _KW_DO_in_for_loop_expr2201 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_for_loop_expr2208 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_BREAK_in_break_expr2246 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_LET_in_let_in_expr2262 = new BitSet(new ulong[]{0xC0400UL});
		public static readonly BitSet _declaration_list_in_let_in_expr2266 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _KW_IN_in_let_in_expr2270 = new BitSet(new ulong[]{0x220106B20UL,0x112000UL});
		public static readonly BitSet _expr_seq_in_let_in_expr2274 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _KW_END_in_let_in_expr2279 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expr_seq2310 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _SEMICOLON_in_expr_seq2314 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_expr_seq2317 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _block_declaration_in_declaration_list2355 = new BitSet(new ulong[]{0xC0402UL});
		public static readonly BitSet _block_type_declaration_in_block_declaration2378 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _block_var_declaration_in_block_declaration2383 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _block_func_declaration_in_block_declaration2388 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_declaration_in_block_type_declaration2401 = new BitSet(new ulong[]{0x40002UL});
		public static readonly BitSet _var_declaration_in_block_var_declaration2422 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _function_declaration_in_block_func_declaration2442 = new BitSet(new ulong[]{0xC0402UL});
		public static readonly BitSet _KW_TYPE_in_type_declaration2465 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_type_declaration2472 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _EQUAL_OP_in_type_declaration2476 = new BitSet(new ulong[]{0x2000010UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_type_declaration2488 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _OPEN_BRACE_in_type_declaration2515 = new BitSet(new ulong[]{0x4000000UL,0x2000UL});
		public static readonly BitSet _type_fields_in_type_declaration2521 = new BitSet(new ulong[]{0x4000000UL});
		public static readonly BitSet _CLOSE_BRACE_in_type_declaration2527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_ARRAY_in_type_declaration2558 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _KW_OF_in_type_declaration2562 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_type_declaration2570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_VAR_in_var_declaration2604 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_var_declaration2614 = new BitSet(new ulong[]{0x80800000UL});
		public static readonly BitSet _ASSIGN_OP_in_var_declaration2622 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_var_declaration2630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _COLON_in_var_declaration2656 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_var_declaration2667 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _ASSIGN_OP_in_var_declaration2674 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_var_declaration2684 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_FUNCTION_in_function_declaration2739 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_function_declaration2747 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OPEN_PARENTHESIS_in_function_declaration2751 = new BitSet(new ulong[]{0x40000000UL,0x2000UL});
		public static readonly BitSet _type_fields_in_function_declaration2755 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _CLOSE_PARENTHESIS_in_function_declaration2759 = new BitSet(new ulong[]{0x4000800000UL});
		public static readonly BitSet _COLON_in_function_declaration2767 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_function_declaration2775 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _EQUAL_OP_in_function_declaration2779 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_function_declaration2787 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_OP_in_function_declaration2831 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_function_declaration2838 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_field_in_type_fields2885 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _COMMA_in_type_fields2888 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _type_field_in_type_fields2890 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _IDENTIFIER_in_type_field2910 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _COLON_in_type_field2916 = new BitSet(new ulong[]{0x0UL,0x2000UL});
		public static readonly BitSet _IDENTIFIER_in_type_field2927 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_synpred1_Tiger1278 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _OPEN_BRACKET_in_synpred1_Tiger1281 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_synpred1_Tiger1284 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _CLOSE_BRACKET_in_synpred1_Tiger1287 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _KW_OF_in_synpred1_Tiger1289 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_synpred2_Tiger1390 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _OPEN_BRACE_in_synpred2_Tiger1395 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_synpred3_Tiger1409 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _OPEN_PARENTHESIS_in_synpred3_Tiger1415 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _KW_IF_in_synpred4_Tiger2003 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_synpred4_Tiger2006 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _KW_THEN_in_synpred4_Tiger2009 = new BitSet(new ulong[]{0x220106A20UL,0x112000UL});
		public static readonly BitSet _expression_in_synpred4_Tiger2012 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _KW_ELSE_in_synpred4_Tiger2015 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
