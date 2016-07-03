grammar MiniJavaGram;
options
{
    language = CSharp;
}
/*
Parser
*/
prog : CLASS PASS+ ID PASS+ OBRACE classBody CBRACE ;

classBody: (COMMETSLASH string* ID*|otherMthod | enumdeclar)* main? (otherMthod | enumdeclar|COMMETSLASH string* ID*)*;

enumdeclar: ENUM PASS+ ID OBRACE (PASS* ID COMMA?)* CBRACE;

main : PUBLIC PASS+ STATIC PASS+ VOID PASS+ 'main' LBRACKET stringArgs RBRACKET PASS+ OBRACE exprassion* CBRACE;

otherMthod: PUBLIC PASS+ STATIC PASS+ (DOUBLE | VOID ) PASS+ ID  LBRACKET args RBRACKET  OBRACE exprassion* CBRACE;


args : (DOUBLE PASS+ ID PASS* COMMA?)*;

exprassion : RETURN PASS+ varible PASS* operator PASS* varible DC
    | SYSTEMOUTPRINTLN LBRACKET (ID LBRACKET ID RBRACKET  | ID|string | ID DOT ID )RBRACKET DC
    | arraydeclaration DC
    | FOR PASS+ LBRACKET DOUBLE PASS+ ID DT PASS+ ID RBRACKET OBRACE exprassion* CBRACE
    | COMMETSLASH string* ID*
    | DOUBLE  PASS+ ID PASS* ASSIGN PASS* doubleVal PASS* DC
    | (DOUBLE  PASS+)? ID PASS* ASSIGN PASS* (ID|doubleVal) PASS* MULT PASS*(ID|doubleVal)  PASS* DC
    | ID LBRACKET (ID COMMA?)* RBRACKET DC


;



arraydeclaration : DOUBLE ARRAYSQARES PASS+ ID PASS* ASSIGN PASS* doubleArr;

varible: ID|doubleVal;

doubleVal:  DIGIT DOT DIGIT ;

doubleArr: OBRACE (doubleVal COMMA?)*CBRACE;

operator: ASSIGN| MULT;

string : DOUBLE_QUOTE (ID PASS* DOT* DT* COMMA* PASS*| ID DOT*)* DOUBLE_QUOTE ;

stringArgs: STRING ARRAYSQARES ' args';
/*
Lexer
*/


RETURN:'return';
CLASS:'class';
STATIC:'static';
DOUBLE:'double';
STRING:'String';
VOID:'void';
ENUM:'enum';
PUBLIC:'public';
FOR:'for';
DOUBLE_QUOTE : '"';
ARRAYSQARES:'[]';
COMMETSLASH:'//';
SYSTEMOUTPRINTLN:'System.out.println';
MULT : '*';
ASSIGN:'=';
OBRACE   : '{';
CBRACE   : '}';
DT:':';
DC:';';
COMMA: ',';
DOT:'.';
LBRACKET : '(';
RBRACKET : ')';
PASS:' ';
DIGIT : [0-9]+;
ID : [a-zA-Z] [a-zA-Z0-9]* ;
WS : [ \r\t\n]+ -> skip ;