grammar GLOSSA;

/*
 * Parser Rules
 */

file : program (functiondefinition | proceduredefinition)*	#filestart
	 ;

program : PROGRAMMA IDENTIFIER declarations* ARXH statementlist TELOS_PROGRAMMATOS	#programstart
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

functiondefinition : SYNARTHSH IDENTIFIER functionarguments? ':' type statementlist TELOS_SYNARTHSHS	#funcdef1
				   | SYNARTHSH IDENTIFIER ':' type statementlist TELOS_SYNARTHSHS						#funcdef2
				   ;

proceduredefinition : DIADIKASIA IDENTIFIER functionarguments? statementlist TELOS_DIADIKASIAS			#procdef1
					| DIADIKASIA IDENTIFIER statementlist TELOS_DIADIKASIAS								#procdef2
					;

variabledeclarations : METABLHTES type ':' IDENTIFIER (','IDENTIFIER)*		#vardecl_alt1
					 | METABLHTES (type ':' IDENTIFIER)+					#vardecl_alt2
					 ;

constantdeclarations : STATHERES (IDENTIFIER EQUALS expressionprimitives)+	#constdecl_alt1
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

functionarguments : IDENTIFIER (COMMA IDENTIFIER)*	#funargs
				  ;

assignment : IDENTIFIER ASSIGNMENT expression	#assign
		   ;

expression : LPAREN expression RPAREN									#expr_paren
		   | <assoc=right> expression POWER expression					#expr_power
		   | op=(PLUS|MINUS|OXI) expression								#expr_unary
		   | expression op=(MUL|DIV) expression							#expr_muldiv
		   | expression op=(PLUS|MINUS) expression						#expr_plusminus
		   | expression op=(EQUALS|NOTEQUALS|LT|GT|LE|GE) expression	#expr_compare
		   | expression KAI expression									#expr_and
		   | expression H expression									#expr_or
		   | buildinfunction LPAREN functionarguments? RPAREN			#expr_bifunccall
		   | IDENTIFIER LPAREN functionarguments? RPAREN				#expr_funcproccall
		   | expressionprimitives										#expr_expressionprimitives
		   ;

buildinfunction : A_M	#buildin_am
				| A_T	#buildin_at
				| E		#buildin_e
				| EF	#buildin_ef
				| HM	#buildin_hm
				| LOG	#buildin_log
				| SYN	#buildin_syn
				| T_R	#buildin_tr
				;

expressionprimitives : INTEGER		#expressionprimitives_int
					 | DECIMAL		#expressionprimitives_dec
					 | STRING		#expressionprimitives_string
					 | IDENTIFIER	#expressionprimitives_identifier
					 ;

type : AKERAIES		#type_akeraies
	 | PRAGMATIKES	#type_pragmatikes
	 | XARAKTHRES	#type_xaraktires
	 | LOGIKES		#type_logikes
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

PROGRAMMA			: 'пяоцяалла';
ARXH				: 'аявг';
TELOS_PROGRAMMATOS	: 'текос_пяоцяаллатос';
SYNARTHSH			: 'сумаятгсг';
TELOS_SYNARTHSHS	: 'текос_сумаятгсгс';
DIADIKASIA			: 'диадийасиа';
TELOS_DIADIKASIAS	: 'текос_диадийасиас';
METABLHTES			: 'летабкгтес';
STATHERES			: 'стахеяес';
AN					: 'ам';
TOTE				: 'тоте';
TELOS_AN			: 'текос_ам';
ALLIOS_AN			: 'аккиыс_ам';
ALLIOS				: 'аккиыс';
ARXH_EPANALIPSIS	: 'аявг_епамакгьгс';
MEXRIS_OTOU			: 'левяис_отоу';
OSO					: 'осо';
EPANALABE			: 'епамакабе';
TELOS_EPANALIPSIS	: 'текос_епамакгьгс';
GIA					: 'циа';
APO					: 'апо';
MEXRI				: 'левяи';
ME_BHMA				: 'ле_бгла';
EPILEKSE			: 'епикене';
PERIPTOSI			: 'пеяиптысг';
TELOS_EPILOGON		: 'текос_епикоцым';
AKERAIES			: 'айеяаиес';
PRAGMATIKES			: 'пяацлатийес';
XARAKTHRES			: 'ваяайтгяес';
LOGIKES				: 'коцийес';
GRAPSE				: 'цяаье';
EKTIPOSE			: 'ейтупысе';
DIABASE				: 'диабасе';
KALESE				: 'йакесе';
TRUE				: 'акгхгс';
FALSE				: 'ьеудгс';
KAI					: 'йаи';
H					: 'г';
OXI					: 'ови';

A_M					: 'а_л';
A_T					: 'а_т';
E					: 'е';
EF					: 'еж';
HM					: 'гл';
LOG					: 'коц';
SYN					: 'сум';
T_R					: 'т_я';

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