grammar Tiger;

options
{
 output=AST;
 ASTLabelType = CommonTree;
 language = CSharp3;
}


tokens
{
// KEYWORDS
KW_ARRAY =    'array';
KW_BREAK =    'break';
KW_DO =       'do';
KW_ELSE =     'else';
KW_END =      'end';
KW_FOR =      'for';
KW_FUNCTION = 'function';
KW_IF =       'if';
KW_IN =       'in';
KW_LET =      'let';
KW_NIL =      'nil';
KW_OF =       'of';
KW_THEN =     'then';
KW_TO =       'to';
KW_TYPE =     'type';
KW_VAR =      'var';
KW_WHILE =    'while';


// PUNCTUATION SYMBOLS

  //<<<<<<<<<<<< SEPARATORS >>>>>>>>>>
      	POINT =     '.';
     	COMMA =     ',';
     	COLON =     ':';
     	SEMICOLON = ';';
  
  //<<<<<<<<<<<< OPERATORS >>>>>>>>>>>

	// ...__GROUP OPERATORS__...
	OPEN_BRACE = 	    '{';
	CLOSE_BRACE = 	    '}';
	OPEN_BRACKET = 	    '[';
	CLOSE_BRACKET =     ']';
	OPEN_PARENTHESIS =  '(';
	CLOSE_PARENTHESIS = ')';
	
	
	// ...__ASSIGNMENT OPERATOR__...
	ASSIGN_OP = ':=';
	
	
	// ...__ARITHMETIC OPERATOR__...	
	PLUS_OP  = '+';
    	MINUS_OP = '-';
    	MULT_OP  = '*';
    	DIV_OP   = '/';
     	
     	
     	// ...__LOGICAL OPERATOR__...	
	AND_OP = '&';
    	OR_OP =  '|';
     	
     	
     	// ...__RELATIONAL OPERATOR__...	
        EQUAL_OP	      = '=' ;
        DISTINCT_OP 	      = '<>';
        LESS_THAN_OP          = '<' ;
        LESS_THAN_EQUAL_OP    = '<=';
        GREATER_THAN_OP	      = '>' ;
        GREATER_THAN_EQUAL_OP = '>=';


//AST TOKENS
UNARY_MINUS_OP;

EXPRESSION_SEQ_INSTR_NODE;

IDENTIFIER_NODE;
IDENTIFIER_NAME;

CALL_FUNCTION_NODE;
FUNCTION_NAME;

RECORD_CREATION_NODE;
FIELD_ASSIGN;
FIELD_ASSIGN_LIST;

ARRAY_CREATION_NODE;


FIELD_ACCES;
SUBSCRIPT_ACCES;

PARAMETERS_CALL;

IF_THEN_NODE;
IF_THEN_ELSE_NODE;

LET_INSTRUCTION_NODE;
EXPR_SEQ_NODE;



DECLARATION_LIST_NODE;

ALIAS_TYPE_DEC_NODE;
ARRAY_TYPE_DEC_NODE;
RECORD_TYPE_DEC_NODE;
FIELDS_RECORD;

INFERENCED_TYPE_VAR_DEC_NODE;
DEFINED_TYPE_VAR_DEC_NODE;

PROCEDURE_DECLARATION_NODE;
FUNCTION_DECLARATION_NODE;
PARAMETERS_DEC;

FIELD_DECLARATION_NODE;


BLOCK_TYPE_DECL;
BLOCK_VAR_DECL;
BLOCK_FUNC_DECL;

}


/*
***************************************************************************
<<<<<<<<<<<<<<<<<<<<<<<<<  ERROR MANAGEMENT CODE   >>>>>>>>>>>>>>>>>>>>>>>>
***************************************************************************
*/

@lexer::header
{
  using TigertronCompiler.ErrorHandling;
}
@lexer::members 
{
    public List<Error> Errors = new List<Error>();
    public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
    {
        string infoError = base.GetErrorMessage(e, tokenNames);
        Errors.Add(new Error(infoError, e.Line, e.CharPositionInLine));
        return infoError;
    }
}

@parser::header
{
  using TigertronCompiler.ErrorHandling;
}
@parser::members 
{
    public List<Error> Errors = new List<Error>();
    public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
    {
        string infoError = base.GetErrorMessage(e, tokenNames);
        Errors.Add(new Error(infoError, e.Line, e.CharPositionInLine));
        return infoError;
    }
}



/****************************************************************************
<<<<<<<<<<<<<<<<<<<<<<<<<  LEXICAL SPECIFICATIONS  >>>>>>>>>>>>>>>>>>>>>>>>>>
****************************************************************************/



IDENTIFIER
	: LETTER (LETTER|DIGIT|'_')*;
	


WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

	 
	 
COMMENT
    :   '/*' ( options {greedy=false;} : COMMENT |. )* '*/' {$channel=HIDDEN;}
    ;
    	
    	
INT_CONSTANT:  DIGIT+;



STRING_CONSTANT
	:DOUBLE_QUOTE (ESC_SEQ | ~(BACK_SLASH|DOUBLE_QUOTE))* DOUBLE_QUOTE;



ESC_SEQ	: BACK_SLASH 
('n' | 'r'			        //newline
|'t'					//tab
|'"'					//double quote 
|BACK_SLASH				//backslash
|'^'('@'|'A'..'Z'|'['|'\\'|']'|'^'|'_') //Control-c, where c is one of @A...Z[\]^_.
|DIGIT  DIGIT  DIGIT			//The character with ASCII code ddd
|(WS)+  BACK_SLASH			//Any sequence of whitespace characters
);


//fragment region
fragment LETTER		: 'a'..'z'|'A'..'Z';
fragment DIGIT		: '0'..'9';
fragment BACK_SLASH     : '\\';
fragment DOUBLE_QUOTE   : '"';




/****************************************************************************
<<<<<<<<<<<<<<<<<<<<<<<<  SINTACTIC SPECIFICATIONS  >>>>>>>>>>>>>>>>>>>>>>>>>
****************************************************************************/

//*****************************************************************
//************************EXPRESSION REGION************************
//*****************************************************************

tiger_program
	: expression EOF!;
	
expression
	: disjunction_expr ;
	
	
disjunction_expr
	: conjunction_expr (OR_OP^ conjunction_expr)* ;
	
conjunction_expr
	: relational_expr (AND_OP^ relational_expr)*	;
	
relational_expr
	: arithmetical_expr (relational_operator^ arithmetical_expr)? ;
	
arithmetical_expr
	: term (add_operator^ term)* ;
	
term	
	: factor (product_operator^ factor)* ;
	
factor	: constant_type
	|(IDENTIFIER  OPEN_BRACKET  expression  CLOSE_BRACKET KW_OF)=>   array_creation
	| flow_control_expr
	| let_in_expr
	| MINUS_OP  factor      ->      ^(UNARY_MINUS_OP   factor)
	| high_acces_assign_expr
	;
	

high_acces_assign_expr
	: assignable_expr     (assign_expr^)?;

assignable_expr	:
	accessible_expr    (high_acces^)*;

accessible_expr
	:  (IDENTIFIER    OPEN_BRACE) =>  record_literal_init 
	|  (IDENTIFIER     OPEN_PARENTHESIS)  =>  call_function_expr 
	|  expr_seq_instr
	|  lvalue;


lvalue//esto es solo para el ast
	: name = IDENTIFIER
	-> ^(IDENTIFIER_NODE  $name);
	
constant_type
	: INT_CONSTANT^
	| STRING_CONSTANT^
	| KW_NIL^;
	
expr_seq_instr
	:OPEN_PARENTHESIS  expr_seq?  CLOSE_PARENTHESIS  
	-> ^(EXPRESSION_SEQ_INSTR_NODE    expr_seq?);
	



//****************************binary operators****************************
relational_operator
	: (EQUAL_OP) | (DISTINCT_OP) | (LESS_THAN_OP) | (LESS_THAN_EQUAL_OP) | (GREATER_THAN_OP) | (GREATER_THAN_EQUAL_OP);
	
add_operator	
	: (PLUS_OP) | (MINUS_OP);

product_operator
	: (MULT_OP) | (DIV_OP);
//**************************end binary operators**************************


//**************************RECORD AND ARRAY LITERAL***************************

record_literal_init
	: name = IDENTIFIER  OPEN_BRACE  field_list?  CLOSE_BRACE
	-> ^(RECORD_CREATION_NODE   $name  ^(FIELD_ASSIGN_LIST   field_list?));
	
field_list
	: field_assign  (COMMA  field_assign)* 
	-> field_assign+ ;
	
field_assign
	:  field_id = IDENTIFIER    EQUAL_OP    value = expression
	-> ^(FIELD_ASSIGN  $field_id   $value);

array_creation
	: name = IDENTIFIER   OPEN_BRACKET    length = expression    CLOSE_BRACKET   KW_OF   init_value = expression
	-> ^(ARRAY_CREATION_NODE   $name   $length     $init_value)
	;

high_acces
	: subscript
	| field ;
	
subscript 
	: OPEN_BRACKET  index = expression  CLOSE_BRACKET
	-> ^(SUBSCRIPT_ACCES  $index);
field	  
	: POINT field_name = IDENTIFIER
	-> ^(FIELD_ACCES  $field_name);
	
//************************END RECORD AND ARRAY LITERAL*************************	
	
	
//**************************FUNCTIONS CALL***************************
call_function_expr
	:  name = IDENTIFIER     OPEN_PARENTHESIS    expr_list?    CLOSE_PARENTHESIS
	-> ^(CALL_FUNCTION_NODE    $name   ^(PARAMETERS_CALL  expr_list?));

expr_list
	: expression  (COMMA  expression)*
	-> expression+ ;
//************************END FUNCTIONS CALL*************************



//**********************ASSIGN REGION**********************
assign_expr
	: ASSIGN_OP^ expression;
//********************END ASSIGN REGION********************



//**********************FLOW CONTROL REGION**********************
flow_control_expr
	: conditional_jump
	| while_loop_expr
	| for_loop_expr
	| break_expr ;

//****CONDITIONAL JUMPS
conditional_jump
	: (KW_IF  expression  KW_THEN  expression  KW_ELSE)
	=> if_then_else_expr
	|  if_then_expr ;
if_then_expr
	: KW_IF cond = expression  KW_THEN  then_expr = expression 
	-> ^(IF_THEN_NODE  $cond   $then_expr)  ;
if_then_else_expr
	: KW_IF   cond = expression  KW_THEN   then_expr = expression  KW_ELSE    else_expr = expression
	-> ^(IF_THEN_ELSE_NODE  $cond   $then_expr   $else_expr)  ;


//******LOOPS*****
while_loop_expr
	: KW_WHILE^  expression   KW_DO!   expression;
		
for_loop_expr
	: KW_FOR   iter_var = IDENTIFIER   ASSIGN_OP   init_value = expression  KW_TO  cond = expression  KW_DO  iter_instr = expression 
	->^(KW_FOR   $cond   $iter_var   $init_value   $iter_instr);
//****************

//inconditional jump		
break_expr
	: KW_BREAK^;

//********************END FLOW CONTROL REGION********************




//**********************LET IN REGION**********************
let_in_expr
	: KW_LET   declaration_list   KW_IN   expr_seq?   KW_END
	-> ^(LET_INSTRUCTION_NODE  declaration_list  ^(EXPRESSION_SEQ_INSTR_NODE  expr_seq?))
	;
	
expr_seq
	: expression  (SEMICOLON  expression)* 
	->   expression+  ;
//********************END LET IN REGION********************


	
//*****************************************************************
//**********************EXPRESSION END_REGION**********************
//*****************************************************************






//*****************************************************************
//***********************DECLARATION REGION************************
//*****************************************************************
declaration_list
	: block_declaration+ 
	-> ^(DECLARATION_LIST_NODE   block_declaration+);

block_declaration
	: block_type_declaration
	| block_var_declaration
	| block_func_declaration
	;
	
block_type_declaration 
	: type_declaration+
	->^(BLOCK_TYPE_DECL type_declaration+);
	
block_var_declaration 
	: var_declaration+
	->^(BLOCK_VAR_DECL var_declaration+);

block_func_declaration 
	: function_declaration+
	->^(BLOCK_FUNC_DECL function_declaration+);
	
	
//**********
type_declaration
	: KW_TYPE  new_type = IDENTIFIER   EQUAL_OP   
	( alias_id = IDENTIFIER 
	->  ^(ALIAS_TYPE_DEC_NODE   $new_type   $alias_id) 
	| 
	OPEN_BRACE     type_fields?    CLOSE_BRACE
	->  ^(RECORD_TYPE_DEC_NODE   $new_type   ^(FIELDS_RECORD  type_fields?)) 
	| 
	KW_ARRAY   KW_OF   type_items = IDENTIFIER
	->  ^(ARRAY_TYPE_DEC_NODE   $new_type   $type_items) 
	);
//**********



//**********
var_declaration
	:KW_VAR     name = IDENTIFIER 
	( 
	ASSIGN_OP   value = expression 
	-> ^(INFERENCED_TYPE_VAR_DEC_NODE    $name    $value)
	|
	COLON      type = IDENTIFIER      ASSIGN_OP     value = expression 
	-> ^(DEFINED_TYPE_VAR_DEC_NODE    $name    $value     $type)
	);
//**********
	
       	
   	
//**********
function_declaration
	:KW_FUNCTION   name_function = IDENTIFIER   OPEN_PARENTHESIS   type_fields?  CLOSE_PARENTHESIS 	
	(
	COLON   type_return = IDENTIFIER   EQUAL_OP  body =  expression
	-> ^(FUNCTION_DECLARATION_NODE    $name_function    ^(PARAMETERS_DEC    type_fields?)    $body    $type_return)
	|
	EQUAL_OP  body = expression
	-> ^(PROCEDURE_DECLARATION_NODE    $name_function    ^(PARAMETERS_DEC    type_fields?)    $body)
	);
//**********

//__auxiliar__
type_fields	
	: type_field (COMMA type_field)* -> type_field+;

type_field
	: name_id = IDENTIFIER     COLON      type_id = IDENTIFIER      
	-> ^(FIELD_DECLARATION_NODE   $name_id    $type_id);

//*****************************************************************
//***********************DECLARATION END_REGION********************
//*****************************************************************
	

