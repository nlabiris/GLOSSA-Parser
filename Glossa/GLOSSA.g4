grammar GLOSSA;

/*
 * Parser Rules
 */

file : program (functiondefinition | proceduredefinition)*	#filestart
	 ;

program : PROGRAMMA IDENTIFIER declarations* ARXH statementlist TELOS_PROGRAMMATOS	#programstart
		;

functiondefinition : SYNARTHSH IDENTIFIER LPAREN functionarguments? RPAREN ':' functionType declarations* ARXH statementlist TELOS_SYNARTHSHS	#funcdef
				   ;

proceduredefinition : DIADIKASIA IDENTIFIER LPAREN functionarguments? RPAREN declarations* ARXH statementlist TELOS_DIADIKASIAS			#procdef
					;

statementlist : statement*	#stmtlist
			  ;

//statementbreak : EOL+;

statement : expression								#stat_expr
		  | assignment								#stat_assignment
		  | keyword expression (COMMA expression)*	#stat_ioexpr
		  | ifcontrol								#stat_ifctrl
		  | dowhileloop								#stat_dowhile
		  | whileloop								#stat_while
		  | switchcontrol							#stat_switch
		  ;

declarations : variabledeclarations					#vardecl
			 | constantdeclarations					#constdecl
			 ;

variabledeclarations : METABLHTES type ':' IDENTIFIER (','IDENTIFIER)*		#vardecl_alt1
					 | METABLHTES (type ':' IDENTIFIER)+					#vardecl_alt2
					 ;

constantdeclarations : STATHERES (IDENTIFIER EQUALS expressionprimitives)+	#constdecl_alt
					 ;

ifcontrol : AN expression TOTE statement* elseif* else? TELOS_AN	#ifctrl
		  ;

elseif : ALLIOS_AN expression TOTE statementlist	#elseifctrl
	   ;

else : ALLIOS statementlist	#elsectrl
	 ;

dowhileloop : ARXH_EPANALIPSIS statementlist MEXRIS_OTOU expression		# dowhilectrl
			;

whileloop : OSO expression EPANALABE statementlist TELOS_EPANALIPSIS	# whilectrl
		  ;

forloop : GIA IDENTIFIER APO INTEGER MEXRI INTEGER ME_BHMA expression statementlist TELOS_EPANALIPSIS	#forctrl
		;

switchcontrol : EPILEKSE IDENTIFIER casescontrol+ otherwisecontrol* TELOS_EPILOGON	#switchctrl
			  ;

casescontrol : PERIPTOSI expression statementlist	#casectrl
			 ;

otherwisecontrol : PERIPTOSI ALLIOS statementlist	#otherwisectrl
				 ;

functionarguments : expressionprimitives (COMMA expressionprimitives)*	#funargs
				  ;

assignment : IDENTIFIER ASSIGNMENT expression	#assign
		   ;

expressionprimitives : INTEGER		#expressionprimitives_int
					 | DECIMAL		#expressionprimitives_dec
					 | STRING		#expressionprimitives_string
					 | IDENTIFIER	#expressionprimitives_identifier
					 ;

expression : LPAREN expression RPAREN									#expr_paren
		   | <assoc=right> expression POWER expression					#expr_power
		   | op=(PLUS|MINUS|OXI) expression								#expr_unary
		   | expression op=(MUL|DIV) expression							#expr_muldiv
		   | expression op=(PLUS|MINUS) expression						#expr_plusminus
		   | expression op=(EQUALS|NOTEQUALS|LT|GT|LE|GE) expression	#expr_compare
		   | expression KAI expression									#expr_and
		   | expression H expression									#expr_or
		   | IDENTIFIER LPAREN functionarguments? RPAREN				#expr_funcproccall
		   | expressionprimitives										#expr_expressionprimitives
		   ;

type : AKERAIES		#type_akeraies
	 | PRAGMATIKES	#type_pragmatikes
	 | XARAKTHRES	#type_xaraktires
	 | LOGIKES		#type_logikes
	 ;

functionType : AKERAIA
			 | PRAGMATIKI
			 | XARAKTHRAS
			 | LOGIKI
			 ;

keyword : GRAPSE		#keyword_grapse
		| EKTIPOSE		#keyword_ektipose
		| DIABASE		#keyword_diabase
		| KALESE		#keyword_kalese
		;

bool : TRUE			#bool_true
	 | FALSE		#bool_false
	 ;


/*
 * Lexer Rules
 */

PROGRAMMA			: '���������';
ARXH				: '����';
TELOS_PROGRAMMATOS	: '�����_������������';
SYNARTHSH			: '���������';
TELOS_SYNARTHSHS	: '�����_����������';
DIADIKASIA			: '����������';
TELOS_DIADIKASIAS	: '�����_�����������';
METABLHTES			: '����������';
STATHERES			: '��������';
AN					: '��';
TOTE				: '����';
TELOS_AN			: '�����_��';
ALLIOS_AN			: '������_��';
ALLIOS				: '������';
ARXH_EPANALIPSIS	: '����_����������';
MEXRIS_OTOU			: '������_����';
OSO					: '���';
EPANALABE			: '���������';
TELOS_EPANALIPSIS	: '�����_����������';
GIA					: '���';
APO					: '���';
MEXRI				: '�����';
ME_BHMA				: '��_����';
EPILEKSE			: '�������';
PERIPTOSI			: '���������';
TELOS_EPILOGON		: '�����_��������';

// Function types
AKERAIA				: '�������';
PRAGMATIKI			: '����������';
XARAKTHRAS			: '����������';
LOGIKI				: '������';

AKERAIES			: '��������';
PRAGMATIKES			: '�����������';
XARAKTHRES			: '����������';
LOGIKES				: '�������';
GRAPSE				: '�����';
EKTIPOSE			: '��������';
DIABASE				: '�������';
KALESE				: '������';
TRUE				: '������';
FALSE				: '������';
KAI					: '���';
H					: '�';
OXI					: '���';

//A_M					: '�_�';
//A_T					: '�_�';
//E					: '�';
//EF					: '��';
//HM					: '��';
//LOG					: '���';
//SYN					: '���';
//T_R					: '�_�';

INTEGER : [0-9]+;
DECIMAL : ([0-9]+'.'[0-9]*)|([0-9]*'.'[0-9]+);
STRING	: '\'' ~[\n\']* '\''
  		| '"' ~[\n\"]* '"'
		;

IDENTIFIER : NameStartChar NameChar*
		   ;


fragment NameChar : NameStartChar
				  | '0'..'9'
				  | '_'
				  ;

fragment NameStartChar : 'A'..'Z'
					   | 'a'..'z'
					   | '\u00B7'
					   | '\u0300'..'\u036F'
				       | '\u203F'..'\u2040'
					   | '\u00C0'..'\u00D6'
					   | '\u00D8'..'\u00F6'
					   | '\u00F8'..'\u02FF'
					   | '\u0370'..'\u037D'
					   | '\u037F'..'\u1FFF'
					   | '\u200C'..'\u200D'
					   | '\u2070'..'\u218F'
					   | '\u2C00'..'\u2FEF'
					   | '\u3001'..'\uD7FF'
					   | '\uF900'..'\uFDCF'
					   | '\uFDF0'..'\uFFFD'
					   ; // ignores | ['\u10000-'\uEFFFF] ;

EQUALS		: '=';
NOTEQUALS	: '<>';
GT			: '>';
GE			: '>=';
LT			: '<';
LE			: '<=';

PLUS		: '+';
MINUS		: '-';
MUL			: '*';
DIV			: '/';
POWER		: '^';
SEMICOLON	: ';';
COMMA		: ',';
ASSIGNMENT	: '<-';
LPAREN		: '(';
RPAREN		: ')';
LBRACKET	: '[';
RBRACKET	: ']';
LANCHOR		: '{';
RANCHOR		: '}';

COMMENTS : '!' ~[\r\n]* ->skip;
//SPACES : [ \t]+; ->skip;
WS : [ \t\r\n] ->skip;
//EOL : '\r'?'\n'+;