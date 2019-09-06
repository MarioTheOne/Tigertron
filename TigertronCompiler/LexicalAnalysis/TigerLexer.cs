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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerLexer : Antlr.Runtime.Lexer
{
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

	    public List<Error> Errors = new List<Error>();
	    public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
	    {
	        string infoError = base.GetErrorMessage(e, tokenNames);
	        Errors.Add(new Error(infoError, e.Line, e.CharPositionInLine,ErrorKind.LexicalError));
	        return infoError;
	    }


    // delegates
    // delegators

	public TigerLexer()
	{
		OnCreated();
	}

	public TigerLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TigerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\Gustavo\\Desktop\\Tiger.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_KW_ARRAY();
	partial void Leave_KW_ARRAY();

	// $ANTLR start "KW_ARRAY"
	[GrammarRule("KW_ARRAY")]
	private void mKW_ARRAY()
	{
		Enter_KW_ARRAY();
		EnterRule("KW_ARRAY", 1);
		TraceIn("KW_ARRAY", 1);
		try
		{
			int _type = KW_ARRAY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:20:10: ( 'array' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:20:12: 'array'
			{
			DebugLocation(20, 12);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_ARRAY", 1);
			LeaveRule("KW_ARRAY", 1);
			Leave_KW_ARRAY();
		}
	}
	// $ANTLR end "KW_ARRAY"

	partial void Enter_KW_BREAK();
	partial void Leave_KW_BREAK();

	// $ANTLR start "KW_BREAK"
	[GrammarRule("KW_BREAK")]
	private void mKW_BREAK()
	{
		Enter_KW_BREAK();
		EnterRule("KW_BREAK", 2);
		TraceIn("KW_BREAK", 2);
		try
		{
			int _type = KW_BREAK;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:21:10: ( 'break' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:21:12: 'break'
			{
			DebugLocation(21, 12);
			Match("break"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_BREAK", 2);
			LeaveRule("KW_BREAK", 2);
			Leave_KW_BREAK();
		}
	}
	// $ANTLR end "KW_BREAK"

	partial void Enter_KW_DO();
	partial void Leave_KW_DO();

	// $ANTLR start "KW_DO"
	[GrammarRule("KW_DO")]
	private void mKW_DO()
	{
		Enter_KW_DO();
		EnterRule("KW_DO", 3);
		TraceIn("KW_DO", 3);
		try
		{
			int _type = KW_DO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:22:7: ( 'do' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:22:9: 'do'
			{
			DebugLocation(22, 9);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_DO", 3);
			LeaveRule("KW_DO", 3);
			Leave_KW_DO();
		}
	}
	// $ANTLR end "KW_DO"

	partial void Enter_KW_ELSE();
	partial void Leave_KW_ELSE();

	// $ANTLR start "KW_ELSE"
	[GrammarRule("KW_ELSE")]
	private void mKW_ELSE()
	{
		Enter_KW_ELSE();
		EnterRule("KW_ELSE", 4);
		TraceIn("KW_ELSE", 4);
		try
		{
			int _type = KW_ELSE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:23:9: ( 'else' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:23:11: 'else'
			{
			DebugLocation(23, 11);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_ELSE", 4);
			LeaveRule("KW_ELSE", 4);
			Leave_KW_ELSE();
		}
	}
	// $ANTLR end "KW_ELSE"

	partial void Enter_KW_END();
	partial void Leave_KW_END();

	// $ANTLR start "KW_END"
	[GrammarRule("KW_END")]
	private void mKW_END()
	{
		Enter_KW_END();
		EnterRule("KW_END", 5);
		TraceIn("KW_END", 5);
		try
		{
			int _type = KW_END;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:24:8: ( 'end' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:24:10: 'end'
			{
			DebugLocation(24, 10);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_END", 5);
			LeaveRule("KW_END", 5);
			Leave_KW_END();
		}
	}
	// $ANTLR end "KW_END"

	partial void Enter_KW_FOR();
	partial void Leave_KW_FOR();

	// $ANTLR start "KW_FOR"
	[GrammarRule("KW_FOR")]
	private void mKW_FOR()
	{
		Enter_KW_FOR();
		EnterRule("KW_FOR", 6);
		TraceIn("KW_FOR", 6);
		try
		{
			int _type = KW_FOR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:25:8: ( 'for' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:25:10: 'for'
			{
			DebugLocation(25, 10);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_FOR", 6);
			LeaveRule("KW_FOR", 6);
			Leave_KW_FOR();
		}
	}
	// $ANTLR end "KW_FOR"

	partial void Enter_KW_FUNCTION();
	partial void Leave_KW_FUNCTION();

	// $ANTLR start "KW_FUNCTION"
	[GrammarRule("KW_FUNCTION")]
	private void mKW_FUNCTION()
	{
		Enter_KW_FUNCTION();
		EnterRule("KW_FUNCTION", 7);
		TraceIn("KW_FUNCTION", 7);
		try
		{
			int _type = KW_FUNCTION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:26:13: ( 'function' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:26:15: 'function'
			{
			DebugLocation(26, 15);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_FUNCTION", 7);
			LeaveRule("KW_FUNCTION", 7);
			Leave_KW_FUNCTION();
		}
	}
	// $ANTLR end "KW_FUNCTION"

	partial void Enter_KW_IF();
	partial void Leave_KW_IF();

	// $ANTLR start "KW_IF"
	[GrammarRule("KW_IF")]
	private void mKW_IF()
	{
		Enter_KW_IF();
		EnterRule("KW_IF", 8);
		TraceIn("KW_IF", 8);
		try
		{
			int _type = KW_IF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:27:7: ( 'if' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:27:9: 'if'
			{
			DebugLocation(27, 9);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_IF", 8);
			LeaveRule("KW_IF", 8);
			Leave_KW_IF();
		}
	}
	// $ANTLR end "KW_IF"

	partial void Enter_KW_IN();
	partial void Leave_KW_IN();

	// $ANTLR start "KW_IN"
	[GrammarRule("KW_IN")]
	private void mKW_IN()
	{
		Enter_KW_IN();
		EnterRule("KW_IN", 9);
		TraceIn("KW_IN", 9);
		try
		{
			int _type = KW_IN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:28:7: ( 'in' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:28:9: 'in'
			{
			DebugLocation(28, 9);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_IN", 9);
			LeaveRule("KW_IN", 9);
			Leave_KW_IN();
		}
	}
	// $ANTLR end "KW_IN"

	partial void Enter_KW_LET();
	partial void Leave_KW_LET();

	// $ANTLR start "KW_LET"
	[GrammarRule("KW_LET")]
	private void mKW_LET()
	{
		Enter_KW_LET();
		EnterRule("KW_LET", 10);
		TraceIn("KW_LET", 10);
		try
		{
			int _type = KW_LET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:29:8: ( 'let' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:29:10: 'let'
			{
			DebugLocation(29, 10);
			Match("let"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_LET", 10);
			LeaveRule("KW_LET", 10);
			Leave_KW_LET();
		}
	}
	// $ANTLR end "KW_LET"

	partial void Enter_KW_NIL();
	partial void Leave_KW_NIL();

	// $ANTLR start "KW_NIL"
	[GrammarRule("KW_NIL")]
	private void mKW_NIL()
	{
		Enter_KW_NIL();
		EnterRule("KW_NIL", 11);
		TraceIn("KW_NIL", 11);
		try
		{
			int _type = KW_NIL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:30:8: ( 'nil' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:30:10: 'nil'
			{
			DebugLocation(30, 10);
			Match("nil"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_NIL", 11);
			LeaveRule("KW_NIL", 11);
			Leave_KW_NIL();
		}
	}
	// $ANTLR end "KW_NIL"

	partial void Enter_KW_OF();
	partial void Leave_KW_OF();

	// $ANTLR start "KW_OF"
	[GrammarRule("KW_OF")]
	private void mKW_OF()
	{
		Enter_KW_OF();
		EnterRule("KW_OF", 12);
		TraceIn("KW_OF", 12);
		try
		{
			int _type = KW_OF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:31:7: ( 'of' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:31:9: 'of'
			{
			DebugLocation(31, 9);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_OF", 12);
			LeaveRule("KW_OF", 12);
			Leave_KW_OF();
		}
	}
	// $ANTLR end "KW_OF"

	partial void Enter_KW_THEN();
	partial void Leave_KW_THEN();

	// $ANTLR start "KW_THEN"
	[GrammarRule("KW_THEN")]
	private void mKW_THEN()
	{
		Enter_KW_THEN();
		EnterRule("KW_THEN", 13);
		TraceIn("KW_THEN", 13);
		try
		{
			int _type = KW_THEN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:32:9: ( 'then' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:32:11: 'then'
			{
			DebugLocation(32, 11);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_THEN", 13);
			LeaveRule("KW_THEN", 13);
			Leave_KW_THEN();
		}
	}
	// $ANTLR end "KW_THEN"

	partial void Enter_KW_TO();
	partial void Leave_KW_TO();

	// $ANTLR start "KW_TO"
	[GrammarRule("KW_TO")]
	private void mKW_TO()
	{
		Enter_KW_TO();
		EnterRule("KW_TO", 14);
		TraceIn("KW_TO", 14);
		try
		{
			int _type = KW_TO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:33:7: ( 'to' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:33:9: 'to'
			{
			DebugLocation(33, 9);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_TO", 14);
			LeaveRule("KW_TO", 14);
			Leave_KW_TO();
		}
	}
	// $ANTLR end "KW_TO"

	partial void Enter_KW_TYPE();
	partial void Leave_KW_TYPE();

	// $ANTLR start "KW_TYPE"
	[GrammarRule("KW_TYPE")]
	private void mKW_TYPE()
	{
		Enter_KW_TYPE();
		EnterRule("KW_TYPE", 15);
		TraceIn("KW_TYPE", 15);
		try
		{
			int _type = KW_TYPE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:34:9: ( 'type' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:34:11: 'type'
			{
			DebugLocation(34, 11);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_TYPE", 15);
			LeaveRule("KW_TYPE", 15);
			Leave_KW_TYPE();
		}
	}
	// $ANTLR end "KW_TYPE"

	partial void Enter_KW_VAR();
	partial void Leave_KW_VAR();

	// $ANTLR start "KW_VAR"
	[GrammarRule("KW_VAR")]
	private void mKW_VAR()
	{
		Enter_KW_VAR();
		EnterRule("KW_VAR", 16);
		TraceIn("KW_VAR", 16);
		try
		{
			int _type = KW_VAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:35:8: ( 'var' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:35:10: 'var'
			{
			DebugLocation(35, 10);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_VAR", 16);
			LeaveRule("KW_VAR", 16);
			Leave_KW_VAR();
		}
	}
	// $ANTLR end "KW_VAR"

	partial void Enter_KW_WHILE();
	partial void Leave_KW_WHILE();

	// $ANTLR start "KW_WHILE"
	[GrammarRule("KW_WHILE")]
	private void mKW_WHILE()
	{
		Enter_KW_WHILE();
		EnterRule("KW_WHILE", 17);
		TraceIn("KW_WHILE", 17);
		try
		{
			int _type = KW_WHILE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:36:10: ( 'while' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:36:12: 'while'
			{
			DebugLocation(36, 12);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KW_WHILE", 17);
			LeaveRule("KW_WHILE", 17);
			Leave_KW_WHILE();
		}
	}
	// $ANTLR end "KW_WHILE"

	partial void Enter_POINT();
	partial void Leave_POINT();

	// $ANTLR start "POINT"
	[GrammarRule("POINT")]
	private void mPOINT()
	{
		Enter_POINT();
		EnterRule("POINT", 18);
		TraceIn("POINT", 18);
		try
		{
			int _type = POINT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:37:7: ( '.' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:37:9: '.'
			{
			DebugLocation(37, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("POINT", 18);
			LeaveRule("POINT", 18);
			Leave_POINT();
		}
	}
	// $ANTLR end "POINT"

	partial void Enter_COMMA();
	partial void Leave_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		Enter_COMMA();
		EnterRule("COMMA", 19);
		TraceIn("COMMA", 19);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:38:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:38:9: ','
			{
			DebugLocation(38, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 19);
			LeaveRule("COMMA", 19);
			Leave_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void Enter_COLON();
	partial void Leave_COLON();

	// $ANTLR start "COLON"
	[GrammarRule("COLON")]
	private void mCOLON()
	{
		Enter_COLON();
		EnterRule("COLON", 20);
		TraceIn("COLON", 20);
		try
		{
			int _type = COLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:39:7: ( ':' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:39:9: ':'
			{
			DebugLocation(39, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COLON", 20);
			LeaveRule("COLON", 20);
			Leave_COLON();
		}
	}
	// $ANTLR end "COLON"

	partial void Enter_SEMICOLON();
	partial void Leave_SEMICOLON();

	// $ANTLR start "SEMICOLON"
	[GrammarRule("SEMICOLON")]
	private void mSEMICOLON()
	{
		Enter_SEMICOLON();
		EnterRule("SEMICOLON", 21);
		TraceIn("SEMICOLON", 21);
		try
		{
			int _type = SEMICOLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:40:11: ( ';' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:40:13: ';'
			{
			DebugLocation(40, 13);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SEMICOLON", 21);
			LeaveRule("SEMICOLON", 21);
			Leave_SEMICOLON();
		}
	}
	// $ANTLR end "SEMICOLON"

	partial void Enter_OPEN_BRACE();
	partial void Leave_OPEN_BRACE();

	// $ANTLR start "OPEN_BRACE"
	[GrammarRule("OPEN_BRACE")]
	private void mOPEN_BRACE()
	{
		Enter_OPEN_BRACE();
		EnterRule("OPEN_BRACE", 22);
		TraceIn("OPEN_BRACE", 22);
		try
		{
			int _type = OPEN_BRACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:41:12: ( '{' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:41:14: '{'
			{
			DebugLocation(41, 14);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_BRACE", 22);
			LeaveRule("OPEN_BRACE", 22);
			Leave_OPEN_BRACE();
		}
	}
	// $ANTLR end "OPEN_BRACE"

	partial void Enter_CLOSE_BRACE();
	partial void Leave_CLOSE_BRACE();

	// $ANTLR start "CLOSE_BRACE"
	[GrammarRule("CLOSE_BRACE")]
	private void mCLOSE_BRACE()
	{
		Enter_CLOSE_BRACE();
		EnterRule("CLOSE_BRACE", 23);
		TraceIn("CLOSE_BRACE", 23);
		try
		{
			int _type = CLOSE_BRACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:42:13: ( '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:42:15: '}'
			{
			DebugLocation(42, 15);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_BRACE", 23);
			LeaveRule("CLOSE_BRACE", 23);
			Leave_CLOSE_BRACE();
		}
	}
	// $ANTLR end "CLOSE_BRACE"

	partial void Enter_OPEN_BRACKET();
	partial void Leave_OPEN_BRACKET();

	// $ANTLR start "OPEN_BRACKET"
	[GrammarRule("OPEN_BRACKET")]
	private void mOPEN_BRACKET()
	{
		Enter_OPEN_BRACKET();
		EnterRule("OPEN_BRACKET", 24);
		TraceIn("OPEN_BRACKET", 24);
		try
		{
			int _type = OPEN_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:43:14: ( '[' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:43:16: '['
			{
			DebugLocation(43, 16);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_BRACKET", 24);
			LeaveRule("OPEN_BRACKET", 24);
			Leave_OPEN_BRACKET();
		}
	}
	// $ANTLR end "OPEN_BRACKET"

	partial void Enter_CLOSE_BRACKET();
	partial void Leave_CLOSE_BRACKET();

	// $ANTLR start "CLOSE_BRACKET"
	[GrammarRule("CLOSE_BRACKET")]
	private void mCLOSE_BRACKET()
	{
		Enter_CLOSE_BRACKET();
		EnterRule("CLOSE_BRACKET", 25);
		TraceIn("CLOSE_BRACKET", 25);
		try
		{
			int _type = CLOSE_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:44:15: ( ']' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:44:17: ']'
			{
			DebugLocation(44, 17);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_BRACKET", 25);
			LeaveRule("CLOSE_BRACKET", 25);
			Leave_CLOSE_BRACKET();
		}
	}
	// $ANTLR end "CLOSE_BRACKET"

	partial void Enter_OPEN_PARENTHESIS();
	partial void Leave_OPEN_PARENTHESIS();

	// $ANTLR start "OPEN_PARENTHESIS"
	[GrammarRule("OPEN_PARENTHESIS")]
	private void mOPEN_PARENTHESIS()
	{
		Enter_OPEN_PARENTHESIS();
		EnterRule("OPEN_PARENTHESIS", 26);
		TraceIn("OPEN_PARENTHESIS", 26);
		try
		{
			int _type = OPEN_PARENTHESIS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:45:18: ( '(' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:45:20: '('
			{
			DebugLocation(45, 20);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPEN_PARENTHESIS", 26);
			LeaveRule("OPEN_PARENTHESIS", 26);
			Leave_OPEN_PARENTHESIS();
		}
	}
	// $ANTLR end "OPEN_PARENTHESIS"

	partial void Enter_CLOSE_PARENTHESIS();
	partial void Leave_CLOSE_PARENTHESIS();

	// $ANTLR start "CLOSE_PARENTHESIS"
	[GrammarRule("CLOSE_PARENTHESIS")]
	private void mCLOSE_PARENTHESIS()
	{
		Enter_CLOSE_PARENTHESIS();
		EnterRule("CLOSE_PARENTHESIS", 27);
		TraceIn("CLOSE_PARENTHESIS", 27);
		try
		{
			int _type = CLOSE_PARENTHESIS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:46:19: ( ')' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:46:21: ')'
			{
			DebugLocation(46, 21);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CLOSE_PARENTHESIS", 27);
			LeaveRule("CLOSE_PARENTHESIS", 27);
			Leave_CLOSE_PARENTHESIS();
		}
	}
	// $ANTLR end "CLOSE_PARENTHESIS"

	partial void Enter_ASSIGN_OP();
	partial void Leave_ASSIGN_OP();

	// $ANTLR start "ASSIGN_OP"
	[GrammarRule("ASSIGN_OP")]
	private void mASSIGN_OP()
	{
		Enter_ASSIGN_OP();
		EnterRule("ASSIGN_OP", 28);
		TraceIn("ASSIGN_OP", 28);
		try
		{
			int _type = ASSIGN_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:47:11: ( ':=' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:47:13: ':='
			{
			DebugLocation(47, 13);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN_OP", 28);
			LeaveRule("ASSIGN_OP", 28);
			Leave_ASSIGN_OP();
		}
	}
	// $ANTLR end "ASSIGN_OP"

	partial void Enter_PLUS_OP();
	partial void Leave_PLUS_OP();

	// $ANTLR start "PLUS_OP"
	[GrammarRule("PLUS_OP")]
	private void mPLUS_OP()
	{
		Enter_PLUS_OP();
		EnterRule("PLUS_OP", 29);
		TraceIn("PLUS_OP", 29);
		try
		{
			int _type = PLUS_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:48:9: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:48:11: '+'
			{
			DebugLocation(48, 11);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS_OP", 29);
			LeaveRule("PLUS_OP", 29);
			Leave_PLUS_OP();
		}
	}
	// $ANTLR end "PLUS_OP"

	partial void Enter_MINUS_OP();
	partial void Leave_MINUS_OP();

	// $ANTLR start "MINUS_OP"
	[GrammarRule("MINUS_OP")]
	private void mMINUS_OP()
	{
		Enter_MINUS_OP();
		EnterRule("MINUS_OP", 30);
		TraceIn("MINUS_OP", 30);
		try
		{
			int _type = MINUS_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:49:10: ( '-' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:49:12: '-'
			{
			DebugLocation(49, 12);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS_OP", 30);
			LeaveRule("MINUS_OP", 30);
			Leave_MINUS_OP();
		}
	}
	// $ANTLR end "MINUS_OP"

	partial void Enter_MULT_OP();
	partial void Leave_MULT_OP();

	// $ANTLR start "MULT_OP"
	[GrammarRule("MULT_OP")]
	private void mMULT_OP()
	{
		Enter_MULT_OP();
		EnterRule("MULT_OP", 31);
		TraceIn("MULT_OP", 31);
		try
		{
			int _type = MULT_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:50:9: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:50:11: '*'
			{
			DebugLocation(50, 11);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT_OP", 31);
			LeaveRule("MULT_OP", 31);
			Leave_MULT_OP();
		}
	}
	// $ANTLR end "MULT_OP"

	partial void Enter_DIV_OP();
	partial void Leave_DIV_OP();

	// $ANTLR start "DIV_OP"
	[GrammarRule("DIV_OP")]
	private void mDIV_OP()
	{
		Enter_DIV_OP();
		EnterRule("DIV_OP", 32);
		TraceIn("DIV_OP", 32);
		try
		{
			int _type = DIV_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:51:8: ( '/' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:51:10: '/'
			{
			DebugLocation(51, 10);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV_OP", 32);
			LeaveRule("DIV_OP", 32);
			Leave_DIV_OP();
		}
	}
	// $ANTLR end "DIV_OP"

	partial void Enter_AND_OP();
	partial void Leave_AND_OP();

	// $ANTLR start "AND_OP"
	[GrammarRule("AND_OP")]
	private void mAND_OP()
	{
		Enter_AND_OP();
		EnterRule("AND_OP", 33);
		TraceIn("AND_OP", 33);
		try
		{
			int _type = AND_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:52:8: ( '&' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:52:10: '&'
			{
			DebugLocation(52, 10);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND_OP", 33);
			LeaveRule("AND_OP", 33);
			Leave_AND_OP();
		}
	}
	// $ANTLR end "AND_OP"

	partial void Enter_OR_OP();
	partial void Leave_OR_OP();

	// $ANTLR start "OR_OP"
	[GrammarRule("OR_OP")]
	private void mOR_OP()
	{
		Enter_OR_OP();
		EnterRule("OR_OP", 34);
		TraceIn("OR_OP", 34);
		try
		{
			int _type = OR_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:53:7: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:53:9: '|'
			{
			DebugLocation(53, 9);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR_OP", 34);
			LeaveRule("OR_OP", 34);
			Leave_OR_OP();
		}
	}
	// $ANTLR end "OR_OP"

	partial void Enter_EQUAL_OP();
	partial void Leave_EQUAL_OP();

	// $ANTLR start "EQUAL_OP"
	[GrammarRule("EQUAL_OP")]
	private void mEQUAL_OP()
	{
		Enter_EQUAL_OP();
		EnterRule("EQUAL_OP", 35);
		TraceIn("EQUAL_OP", 35);
		try
		{
			int _type = EQUAL_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:54:10: ( '=' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:54:12: '='
			{
			DebugLocation(54, 12);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL_OP", 35);
			LeaveRule("EQUAL_OP", 35);
			Leave_EQUAL_OP();
		}
	}
	// $ANTLR end "EQUAL_OP"

	partial void Enter_DISTINCT_OP();
	partial void Leave_DISTINCT_OP();

	// $ANTLR start "DISTINCT_OP"
	[GrammarRule("DISTINCT_OP")]
	private void mDISTINCT_OP()
	{
		Enter_DISTINCT_OP();
		EnterRule("DISTINCT_OP", 36);
		TraceIn("DISTINCT_OP", 36);
		try
		{
			int _type = DISTINCT_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:55:13: ( '<>' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:55:15: '<>'
			{
			DebugLocation(55, 15);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DISTINCT_OP", 36);
			LeaveRule("DISTINCT_OP", 36);
			Leave_DISTINCT_OP();
		}
	}
	// $ANTLR end "DISTINCT_OP"

	partial void Enter_LESS_THAN_OP();
	partial void Leave_LESS_THAN_OP();

	// $ANTLR start "LESS_THAN_OP"
	[GrammarRule("LESS_THAN_OP")]
	private void mLESS_THAN_OP()
	{
		Enter_LESS_THAN_OP();
		EnterRule("LESS_THAN_OP", 37);
		TraceIn("LESS_THAN_OP", 37);
		try
		{
			int _type = LESS_THAN_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:56:14: ( '<' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:56:16: '<'
			{
			DebugLocation(56, 16);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS_THAN_OP", 37);
			LeaveRule("LESS_THAN_OP", 37);
			Leave_LESS_THAN_OP();
		}
	}
	// $ANTLR end "LESS_THAN_OP"

	partial void Enter_LESS_THAN_EQUAL_OP();
	partial void Leave_LESS_THAN_EQUAL_OP();

	// $ANTLR start "LESS_THAN_EQUAL_OP"
	[GrammarRule("LESS_THAN_EQUAL_OP")]
	private void mLESS_THAN_EQUAL_OP()
	{
		Enter_LESS_THAN_EQUAL_OP();
		EnterRule("LESS_THAN_EQUAL_OP", 38);
		TraceIn("LESS_THAN_EQUAL_OP", 38);
		try
		{
			int _type = LESS_THAN_EQUAL_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:57:20: ( '<=' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:57:22: '<='
			{
			DebugLocation(57, 22);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS_THAN_EQUAL_OP", 38);
			LeaveRule("LESS_THAN_EQUAL_OP", 38);
			Leave_LESS_THAN_EQUAL_OP();
		}
	}
	// $ANTLR end "LESS_THAN_EQUAL_OP"

	partial void Enter_GREATER_THAN_OP();
	partial void Leave_GREATER_THAN_OP();

	// $ANTLR start "GREATER_THAN_OP"
	[GrammarRule("GREATER_THAN_OP")]
	private void mGREATER_THAN_OP()
	{
		Enter_GREATER_THAN_OP();
		EnterRule("GREATER_THAN_OP", 39);
		TraceIn("GREATER_THAN_OP", 39);
		try
		{
			int _type = GREATER_THAN_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:58:17: ( '>' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:58:19: '>'
			{
			DebugLocation(58, 19);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER_THAN_OP", 39);
			LeaveRule("GREATER_THAN_OP", 39);
			Leave_GREATER_THAN_OP();
		}
	}
	// $ANTLR end "GREATER_THAN_OP"

	partial void Enter_GREATER_THAN_EQUAL_OP();
	partial void Leave_GREATER_THAN_EQUAL_OP();

	// $ANTLR start "GREATER_THAN_EQUAL_OP"
	[GrammarRule("GREATER_THAN_EQUAL_OP")]
	private void mGREATER_THAN_EQUAL_OP()
	{
		Enter_GREATER_THAN_EQUAL_OP();
		EnterRule("GREATER_THAN_EQUAL_OP", 40);
		TraceIn("GREATER_THAN_EQUAL_OP", 40);
		try
		{
			int _type = GREATER_THAN_EQUAL_OP;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:59:23: ( '>=' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:59:25: '>='
			{
			DebugLocation(59, 25);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER_THAN_EQUAL_OP", 40);
			LeaveRule("GREATER_THAN_EQUAL_OP", 40);
			Leave_GREATER_THAN_EQUAL_OP();
		}
	}
	// $ANTLR end "GREATER_THAN_EQUAL_OP"

	partial void Enter_IDENTIFIER();
	partial void Leave_IDENTIFIER();

	// $ANTLR start "IDENTIFIER"
	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		Enter_IDENTIFIER();
		EnterRule("IDENTIFIER", 41);
		TraceIn("IDENTIFIER", 41);
		try
		{
			int _type = IDENTIFIER;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:177:2: ( LETTER ( LETTER | DIGIT | '_' )* )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:177:4: LETTER ( LETTER | DIGIT | '_' )*
			{
			DebugLocation(177, 4);
			mLETTER(); 
			DebugLocation(177, 11);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:177:11: ( LETTER | DIGIT | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:
					{
					DebugLocation(177, 11);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


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

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENTIFIER", 41);
			LeaveRule("IDENTIFIER", 41);
			Leave_IDENTIFIER();
		}
	}
	// $ANTLR end "IDENTIFIER"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 42);
		TraceIn("WS", 42);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:181:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:181:9: ( ' ' | '\\t' | '\\r' | '\\n' )
			{
			DebugLocation(181, 9);
			if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(185, 11);
			_channel=TokenChannels.Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 42);
			LeaveRule("WS", 42);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_COMMENT();
	partial void Leave_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		Enter_COMMENT();
		EnterRule("COMMENT", 43);
		TraceIn("COMMENT", 43);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:191:5: ( '/*' ( options {greedy=false; } : COMMENT | . )* '*/' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:191:9: '/*' ( options {greedy=false; } : COMMENT | . )* '*/'
			{
			DebugLocation(191, 9);
			Match("/*"); 

			DebugLocation(191, 14);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:191:14: ( options {greedy=false; } : COMMENT | . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=3;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='*'))
				{
					int LA2_1 = input.LA(2);

					if ((LA2_1=='/'))
					{
						alt2=3;
					}
					else if (((LA2_1>='\u0000' && LA2_1<='.')||(LA2_1>='0' && LA2_1<='\uFFFF')))
					{
						alt2=2;
					}


				}
				else if ((LA2_0=='/'))
				{
					int LA2_2 = input.LA(2);

					if ((LA2_2=='*'))
					{
						alt2=1;
					}
					else if (((LA2_2>='\u0000' && LA2_2<=')')||(LA2_2>='+' && LA2_2<='\uFFFF')))
					{
						alt2=2;
					}


				}
				else if (((LA2_0>='\u0000' && LA2_0<=')')||(LA2_0>='+' && LA2_0<='.')||(LA2_0>='0' && LA2_0<='\uFFFF')))
				{
					alt2=2;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:191:42: COMMENT
					{
					DebugLocation(191, 42);
					mCOMMENT(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:191:51: .
					{
					DebugLocation(191, 51);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(191, 56);
			Match("*/"); 

			DebugLocation(191, 61);
			_channel=TokenChannels.Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 43);
			LeaveRule("COMMENT", 43);
			Leave_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void Enter_INT_CONSTANT();
	partial void Leave_INT_CONSTANT();

	// $ANTLR start "INT_CONSTANT"
	[GrammarRule("INT_CONSTANT")]
	private void mINT_CONSTANT()
	{
		Enter_INT_CONSTANT();
		EnterRule("INT_CONSTANT", 44);
		TraceIn("INT_CONSTANT", 44);
		try
		{
			int _type = INT_CONSTANT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:195:13: ( ( DIGIT )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:195:16: ( DIGIT )+
			{
			DebugLocation(195, 16);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:195:16: ( DIGIT )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:195:16: DIGIT
					{
					DebugLocation(195, 16);
					mDIGIT(); 

					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT_CONSTANT", 44);
			LeaveRule("INT_CONSTANT", 44);
			Leave_INT_CONSTANT();
		}
	}
	// $ANTLR end "INT_CONSTANT"

	partial void Enter_STRING_CONSTANT();
	partial void Leave_STRING_CONSTANT();

	// $ANTLR start "STRING_CONSTANT"
	[GrammarRule("STRING_CONSTANT")]
	private void mSTRING_CONSTANT()
	{
		Enter_STRING_CONSTANT();
		EnterRule("STRING_CONSTANT", 45);
		TraceIn("STRING_CONSTANT", 45);
		try
		{
			int _type = STRING_CONSTANT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:200:2: ( DOUBLE_QUOTE ( ESC_SEQ | ~ ( BACK_SLASH | DOUBLE_QUOTE ) )* DOUBLE_QUOTE )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:200:3: DOUBLE_QUOTE ( ESC_SEQ | ~ ( BACK_SLASH | DOUBLE_QUOTE ) )* DOUBLE_QUOTE
			{
			DebugLocation(200, 3);
			mDOUBLE_QUOTE(); 
			DebugLocation(200, 16);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:200:16: ( ESC_SEQ | ~ ( BACK_SLASH | DOUBLE_QUOTE ) )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=3;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='\\'))
				{
					alt4=1;
				}
				else if (((LA4_0>='\u0000' && LA4_0<='!')||(LA4_0>='#' && LA4_0<='[')||(LA4_0>=']' && LA4_0<='\uFFFF')))
				{
					alt4=2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:200:17: ESC_SEQ
					{
					DebugLocation(200, 17);
					mESC_SEQ(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Gustavo\\Desktop\\Tiger.g:200:27: ~ ( BACK_SLASH | DOUBLE_QUOTE )
					{
					DebugLocation(200, 27);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(200, 56);
			mDOUBLE_QUOTE(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING_CONSTANT", 45);
			LeaveRule("STRING_CONSTANT", 45);
			Leave_STRING_CONSTANT();
		}
	}
	// $ANTLR end "STRING_CONSTANT"

	partial void Enter_ESC_SEQ();
	partial void Leave_ESC_SEQ();

	// $ANTLR start "ESC_SEQ"
	[GrammarRule("ESC_SEQ")]
	private void mESC_SEQ()
	{
		Enter_ESC_SEQ();
		EnterRule("ESC_SEQ", 46);
		TraceIn("ESC_SEQ", 46);
		try
		{
			int _type = ESC_SEQ;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:204:9: ( BACK_SLASH ( 'n' | 'r' | 't' | '\"' | BACK_SLASH | '^' ( '@' | 'A' .. 'Z' | '[' | '\\\\' | ']' | '^' | '_' ) | DIGIT DIGIT DIGIT | ( WS )+ BACK_SLASH ) )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:204:11: BACK_SLASH ( 'n' | 'r' | 't' | '\"' | BACK_SLASH | '^' ( '@' | 'A' .. 'Z' | '[' | '\\\\' | ']' | '^' | '_' ) | DIGIT DIGIT DIGIT | ( WS )+ BACK_SLASH )
			{
			DebugLocation(204, 11);
			mBACK_SLASH(); 
			DebugLocation(205, 1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:205:1: ( 'n' | 'r' | 't' | '\"' | BACK_SLASH | '^' ( '@' | 'A' .. 'Z' | '[' | '\\\\' | ']' | '^' | '_' ) | DIGIT DIGIT DIGIT | ( WS )+ BACK_SLASH )
			int alt6=8;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			switch (input.LA(1))
			{
			case 'n':
				{
				alt6=1;
				}
				break;
			case 'r':
				{
				alt6=2;
				}
				break;
			case 't':
				{
				alt6=3;
				}
				break;
			case '\"':
				{
				alt6=4;
				}
				break;
			case '\\':
				{
				alt6=5;
				}
				break;
			case '^':
				{
				alt6=6;
				}
				break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				{
				alt6=7;
				}
				break;
			case '\t':
			case '\n':
			case '\r':
			case ' ':
				{
				alt6=8;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:205:2: 'n'
				{
				DebugLocation(205, 2);
				Match('n'); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:205:8: 'r'
				{
				DebugLocation(205, 8);
				Match('r'); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:206:2: 't'
				{
				DebugLocation(206, 2);
				Match('t'); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:207:2: '\"'
				{
				DebugLocation(207, 2);
				Match('\"'); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:208:2: BACK_SLASH
				{
				DebugLocation(208, 2);
				mBACK_SLASH(); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:209:2: '^' ( '@' | 'A' .. 'Z' | '[' | '\\\\' | ']' | '^' | '_' )
				{
				DebugLocation(209, 2);
				Match('^'); 
				DebugLocation(209, 5);
				if ((input.LA(1)>='@' && input.LA(1)<='_'))
				{
					input.Consume();

				}
				else
				{
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					Recover(mse);
					throw mse;}


				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:210:2: DIGIT DIGIT DIGIT
				{
				DebugLocation(210, 2);
				mDIGIT(); 
				DebugLocation(210, 9);
				mDIGIT(); 
				DebugLocation(210, 16);
				mDIGIT(); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:211:2: ( WS )+ BACK_SLASH
				{
				DebugLocation(211, 2);
				// C:\\Users\\Gustavo\\Desktop\\Tiger.g:211:2: ( WS )+
				int cnt5=0;
				try { DebugEnterSubRule(5);
				while (true)
				{
					int alt5=2;
					try { DebugEnterDecision(5, decisionCanBacktrack[5]);
					int LA5_0 = input.LA(1);

					if (((LA5_0>='\t' && LA5_0<='\n')||LA5_0=='\r'||LA5_0==' '))
					{
						alt5=1;
					}


					} finally { DebugExitDecision(5); }
					switch (alt5)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\Gustavo\\Desktop\\Tiger.g:211:3: WS
						{
						DebugLocation(211, 3);
						mWS(); 

						}
						break;

					default:
						if (cnt5 >= 1)
							goto loop5;

						EarlyExitException eee5 = new EarlyExitException( 5, input );
						DebugRecognitionException(eee5);
						throw eee5;
					}
					cnt5++;
				}
				loop5:
					;

				} finally { DebugExitSubRule(5); }

				DebugLocation(211, 9);
				mBACK_SLASH(); 

				}
				break;

			}
			} finally { DebugExitSubRule(6); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ESC_SEQ", 46);
			LeaveRule("ESC_SEQ", 46);
			Leave_ESC_SEQ();
		}
	}
	// $ANTLR end "ESC_SEQ"

	partial void Enter_LETTER();
	partial void Leave_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		Enter_LETTER();
		EnterRule("LETTER", 47);
		TraceIn("LETTER", 47);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:216:18: ( 'a' .. 'z' | 'A' .. 'Z' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:
			{
			DebugLocation(216, 18);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("LETTER", 47);
			LeaveRule("LETTER", 47);
			Leave_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void Enter_DIGIT();
	partial void Leave_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		Enter_DIGIT();
		EnterRule("DIGIT", 48);
		TraceIn("DIGIT", 48);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:217:17: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:217:19: '0' .. '9'
			{
			DebugLocation(217, 19);
			MatchRange('0','9'); 

			}

		}
		finally
		{
			TraceOut("DIGIT", 48);
			LeaveRule("DIGIT", 48);
			Leave_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void Enter_BACK_SLASH();
	partial void Leave_BACK_SLASH();

	// $ANTLR start "BACK_SLASH"
	[GrammarRule("BACK_SLASH")]
	private void mBACK_SLASH()
	{
		Enter_BACK_SLASH();
		EnterRule("BACK_SLASH", 49);
		TraceIn("BACK_SLASH", 49);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:218:25: ( '\\\\' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:218:27: '\\\\'
			{
			DebugLocation(218, 27);
			Match('\\'); 

			}

		}
		finally
		{
			TraceOut("BACK_SLASH", 49);
			LeaveRule("BACK_SLASH", 49);
			Leave_BACK_SLASH();
		}
	}
	// $ANTLR end "BACK_SLASH"

	partial void Enter_DOUBLE_QUOTE();
	partial void Leave_DOUBLE_QUOTE();

	// $ANTLR start "DOUBLE_QUOTE"
	[GrammarRule("DOUBLE_QUOTE")]
	private void mDOUBLE_QUOTE()
	{
		Enter_DOUBLE_QUOTE();
		EnterRule("DOUBLE_QUOTE", 50);
		TraceIn("DOUBLE_QUOTE", 50);
		try
		{
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:219:25: ( '\"' )
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:219:27: '\"'
			{
			DebugLocation(219, 27);
			Match('\"'); 

			}

		}
		finally
		{
			TraceOut("DOUBLE_QUOTE", 50);
			LeaveRule("DOUBLE_QUOTE", 50);
			Leave_DOUBLE_QUOTE();
		}
	}
	// $ANTLR end "DOUBLE_QUOTE"

	public override void mTokens()
	{
		// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:8: ( KW_ARRAY | KW_BREAK | KW_DO | KW_ELSE | KW_END | KW_FOR | KW_FUNCTION | KW_IF | KW_IN | KW_LET | KW_NIL | KW_OF | KW_THEN | KW_TO | KW_TYPE | KW_VAR | KW_WHILE | POINT | COMMA | COLON | SEMICOLON | OPEN_BRACE | CLOSE_BRACE | OPEN_BRACKET | CLOSE_BRACKET | OPEN_PARENTHESIS | CLOSE_PARENTHESIS | ASSIGN_OP | PLUS_OP | MINUS_OP | MULT_OP | DIV_OP | AND_OP | OR_OP | EQUAL_OP | DISTINCT_OP | LESS_THAN_OP | LESS_THAN_EQUAL_OP | GREATER_THAN_OP | GREATER_THAN_EQUAL_OP | IDENTIFIER | WS | COMMENT | INT_CONSTANT | STRING_CONSTANT | ESC_SEQ )
		int alt7=46;
		try { DebugEnterDecision(7, decisionCanBacktrack[7]);
		try
		{
			alt7 = dfa7.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(7); }
		switch (alt7)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:10: KW_ARRAY
			{
			DebugLocation(1, 10);
			mKW_ARRAY(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:19: KW_BREAK
			{
			DebugLocation(1, 19);
			mKW_BREAK(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:28: KW_DO
			{
			DebugLocation(1, 28);
			mKW_DO(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:34: KW_ELSE
			{
			DebugLocation(1, 34);
			mKW_ELSE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:42: KW_END
			{
			DebugLocation(1, 42);
			mKW_END(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:49: KW_FOR
			{
			DebugLocation(1, 49);
			mKW_FOR(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:56: KW_FUNCTION
			{
			DebugLocation(1, 56);
			mKW_FUNCTION(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:68: KW_IF
			{
			DebugLocation(1, 68);
			mKW_IF(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:74: KW_IN
			{
			DebugLocation(1, 74);
			mKW_IN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:80: KW_LET
			{
			DebugLocation(1, 80);
			mKW_LET(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:87: KW_NIL
			{
			DebugLocation(1, 87);
			mKW_NIL(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:94: KW_OF
			{
			DebugLocation(1, 94);
			mKW_OF(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:100: KW_THEN
			{
			DebugLocation(1, 100);
			mKW_THEN(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:108: KW_TO
			{
			DebugLocation(1, 108);
			mKW_TO(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:114: KW_TYPE
			{
			DebugLocation(1, 114);
			mKW_TYPE(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:122: KW_VAR
			{
			DebugLocation(1, 122);
			mKW_VAR(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:129: KW_WHILE
			{
			DebugLocation(1, 129);
			mKW_WHILE(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:138: POINT
			{
			DebugLocation(1, 138);
			mPOINT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:144: COMMA
			{
			DebugLocation(1, 144);
			mCOMMA(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:150: COLON
			{
			DebugLocation(1, 150);
			mCOLON(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:156: SEMICOLON
			{
			DebugLocation(1, 156);
			mSEMICOLON(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:166: OPEN_BRACE
			{
			DebugLocation(1, 166);
			mOPEN_BRACE(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:177: CLOSE_BRACE
			{
			DebugLocation(1, 177);
			mCLOSE_BRACE(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:189: OPEN_BRACKET
			{
			DebugLocation(1, 189);
			mOPEN_BRACKET(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:202: CLOSE_BRACKET
			{
			DebugLocation(1, 202);
			mCLOSE_BRACKET(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:216: OPEN_PARENTHESIS
			{
			DebugLocation(1, 216);
			mOPEN_PARENTHESIS(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:233: CLOSE_PARENTHESIS
			{
			DebugLocation(1, 233);
			mCLOSE_PARENTHESIS(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:251: ASSIGN_OP
			{
			DebugLocation(1, 251);
			mASSIGN_OP(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:261: PLUS_OP
			{
			DebugLocation(1, 261);
			mPLUS_OP(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:269: MINUS_OP
			{
			DebugLocation(1, 269);
			mMINUS_OP(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:278: MULT_OP
			{
			DebugLocation(1, 278);
			mMULT_OP(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:286: DIV_OP
			{
			DebugLocation(1, 286);
			mDIV_OP(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:293: AND_OP
			{
			DebugLocation(1, 293);
			mAND_OP(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:300: OR_OP
			{
			DebugLocation(1, 300);
			mOR_OP(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:306: EQUAL_OP
			{
			DebugLocation(1, 306);
			mEQUAL_OP(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:315: DISTINCT_OP
			{
			DebugLocation(1, 315);
			mDISTINCT_OP(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:327: LESS_THAN_OP
			{
			DebugLocation(1, 327);
			mLESS_THAN_OP(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:340: LESS_THAN_EQUAL_OP
			{
			DebugLocation(1, 340);
			mLESS_THAN_EQUAL_OP(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:359: GREATER_THAN_OP
			{
			DebugLocation(1, 359);
			mGREATER_THAN_OP(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:375: GREATER_THAN_EQUAL_OP
			{
			DebugLocation(1, 375);
			mGREATER_THAN_EQUAL_OP(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:397: IDENTIFIER
			{
			DebugLocation(1, 397);
			mIDENTIFIER(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:408: WS
			{
			DebugLocation(1, 408);
			mWS(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:411: COMMENT
			{
			DebugLocation(1, 411);
			mCOMMENT(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:419: INT_CONSTANT
			{
			DebugLocation(1, 419);
			mINT_CONSTANT(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:432: STRING_CONSTANT
			{
			DebugLocation(1, 432);
			mSTRING_CONSTANT(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// C:\\Users\\Gustavo\\Desktop\\Tiger.g:1:448: ESC_SEQ
			{
			DebugLocation(1, 448);
			mESC_SEQ(); 

			}
			break;

		}

	}


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x1\xFFFF\xC\x20\x2\xFFFF\x1\x37\xA\xFFFF\x1\x39\x3\xFFFF\x1\x3C\x1"+
			"\x3E\x5\xFFFF\x2\x20\x1\x41\x4\x20\x1\x46\x1\x47\x2\x20\x1\x4A\x1\x20"+
			"\x1\x4C\x3\x20\x9\xFFFF\x2\x20\x1\xFFFF\x1\x20\x1\x53\x1\x54\x1\x20\x2"+
			"\xFFFF\x1\x56\x1\x57\x1\xFFFF\x1\x20\x1\xFFFF\x1\x20\x1\x5A\x3\x20\x1"+
			"\x5E\x2\xFFFF\x1\x20\x2\xFFFF\x1\x60\x1\x61\x1\xFFFF\x1\x20\x1\x63\x1"+
			"\x64\x1\xFFFF\x1\x20\x2\xFFFF\x1\x66\x2\xFFFF\x1\x20\x1\xFFFF\x1\x20"+
			"\x1\x69\x1\xFFFF";
		private const string DFA7_eofS =
			"\x6A\xFFFF";
		private const string DFA7_minS =
			"\x1\x9\x2\x72\x1\x6F\x1\x6C\x1\x6F\x1\x66\x1\x65\x1\x69\x1\x66\x1\x68"+
			"\x1\x61\x1\x68\x2\xFFFF\x1\x3D\xA\xFFFF\x1\x2A\x3\xFFFF\x2\x3D\x5\xFFFF"+
			"\x1\x72\x1\x65\x1\x30\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x30\x1\x74\x1\x6C"+
			"\x1\x30\x1\x65\x1\x30\x1\x70\x1\x72\x1\x69\x9\xFFFF\x2\x61\x1\xFFFF\x1"+
			"\x65\x2\x30\x1\x63\x2\xFFFF\x2\x30\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x65\x1"+
			"\x30\x1\x6C\x1\x79\x1\x6B\x1\x30\x2\xFFFF\x1\x74\x2\xFFFF\x2\x30\x1\xFFFF"+
			"\x1\x65\x2\x30\x1\xFFFF\x1\x69\x2\xFFFF\x1\x30\x2\xFFFF\x1\x6F\x1\xFFFF"+
			"\x1\x6E\x1\x30\x1\xFFFF";
		private const string DFA7_maxS =
			"\x1\x7D\x2\x72\x1\x6F\x1\x6E\x1\x75\x1\x6E\x1\x65\x1\x69\x1\x66\x1\x79"+
			"\x1\x61\x1\x68\x2\xFFFF\x1\x3D\xA\xFFFF\x1\x2A\x3\xFFFF\x1\x3E\x1\x3D"+
			"\x5\xFFFF\x1\x72\x1\x65\x1\x7A\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x7A\x1"+
			"\x74\x1\x6C\x1\x7A\x1\x65\x1\x7A\x1\x70\x1\x72\x1\x69\x9\xFFFF\x2\x61"+
			"\x1\xFFFF\x1\x65\x2\x7A\x1\x63\x2\xFFFF\x2\x7A\x1\xFFFF\x1\x6E\x1\xFFFF"+
			"\x1\x65\x1\x7A\x1\x6C\x1\x79\x1\x6B\x1\x7A\x2\xFFFF\x1\x74\x2\xFFFF\x2"+
			"\x7A\x1\xFFFF\x1\x65\x2\x7A\x1\xFFFF\x1\x69\x2\xFFFF\x1\x7A\x2\xFFFF"+
			"\x1\x6F\x1\xFFFF\x1\x6E\x1\x7A\x1\xFFFF";
		private const string DFA7_acceptS =
			"\xD\xFFFF\x1\x12\x1\x13\x1\xFFFF\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19"+
			"\x1\x1A\x1\x1B\x1\x1D\x1\x1E\x1\x1F\x1\xFFFF\x1\x21\x1\x22\x1\x23\x2"+
			"\xFFFF\x1\x29\x1\x2A\x1\x2C\x1\x2D\x1\x2E\x11\xFFFF\x1\x1C\x1\x14\x1"+
			"\x2B\x1\x20\x1\x24\x1\x26\x1\x25\x1\x28\x1\x27\x2\xFFFF\x1\x3\x4\xFFFF"+
			"\x1\x8\x1\x9\x2\xFFFF\x1\xC\x1\xFFFF\x1\xE\x6\xFFFF\x1\x5\x1\x6\x1\xFFFF"+
			"\x1\xA\x1\xB\x2\xFFFF\x1\x10\x3\xFFFF\x1\x4\x1\xFFFF\x1\xD\x1\xF\x1\xFFFF"+
			"\x1\x1\x1\x2\x1\xFFFF\x1\x11\x2\xFFFF\x1\x7";
		private const string DFA7_specialS =
			"\x6A\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x2\x21\x2\xFFFF\x1\x21\x12\xFFFF\x1\x21\x1\xFFFF\x1\x23\x3\xFFFF\x1"+
				"\x1B\x1\xFFFF\x1\x15\x1\x16\x1\x19\x1\x17\x1\xE\x1\x18\x1\xD\x1\x1A"+
				"\xA\x22\x1\xF\x1\x10\x1\x1E\x1\x1D\x1\x1F\x2\xFFFF\x1A\x20\x1\x13\x1"+
				"\x24\x1\x14\x3\xFFFF\x1\x1\x1\x2\x1\x20\x1\x3\x1\x4\x1\x5\x2\x20\x1"+
				"\x6\x2\x20\x1\x7\x1\x20\x1\x8\x1\x9\x4\x20\x1\xA\x1\x20\x1\xB\x1\xC"+
				"\x3\x20\x1\x11\x1\x1C\x1\x12",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"\x1\x28\x1\xFFFF\x1\x29",
				"\x1\x2A\x5\xFFFF\x1\x2B",
				"\x1\x2C\x7\xFFFF\x1\x2D",
				"\x1\x2E",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31\x6\xFFFF\x1\x32\x9\xFFFF\x1\x33",
				"\x1\x34",
				"\x1\x35",
				"",
				"",
				"\x1\x36",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x38",
				"",
				"",
				"",
				"\x1\x3B\x1\x3A",
				"\x1\x3D",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3F",
				"\x1\x40",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"\x1\x45",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x48",
				"\x1\x49",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4B",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4D",
				"\x1\x4E",
				"\x1\x4F",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x50",
				"\x1\x51",
				"",
				"\x1\x52",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x55",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x58",
				"",
				"\x1\x59",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x5B",
				"\x1\x5C",
				"\x1\x5D",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x5F",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x62",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x65",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x67",
				"",
				"\x1\x68",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( KW_ARRAY | KW_BREAK | KW_DO | KW_ELSE | KW_END | KW_FOR | KW_FUNCTION | KW_IF | KW_IN | KW_LET | KW_NIL | KW_OF | KW_THEN | KW_TO | KW_TYPE | KW_VAR | KW_WHILE | POINT | COMMA | COLON | SEMICOLON | OPEN_BRACE | CLOSE_BRACE | OPEN_BRACKET | CLOSE_BRACKET | OPEN_PARENTHESIS | CLOSE_PARENTHESIS | ASSIGN_OP | PLUS_OP | MINUS_OP | MULT_OP | DIV_OP | AND_OP | OR_OP | EQUAL_OP | DISTINCT_OP | LESS_THAN_OP | LESS_THAN_EQUAL_OP | GREATER_THAN_OP | GREATER_THAN_EQUAL_OP | IDENTIFIER | WS | COMMENT | INT_CONSTANT | STRING_CONSTANT | ESC_SEQ );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
