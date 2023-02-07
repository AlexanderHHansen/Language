grammar Simple;

program: statementOrNewline* EOF;

statementOrNewline: statement | newline;

statement: 
        (expression
    |   assignment
    |   loop
    |   print) newline;

newline: ('\n' | '\r')+;

loop: whileLoop;

whileLoop: WHILE expression LBRACKET (statementOrNewline)* RBRACKET;
WHILE: 'while';
LBRACKET: '{';
RBRACKET: '}';

print: PRINT LPAREN expression RPAREN;
PRINT: 'print';
LPAREN: '(';
RPAREN: ')';

expression
    :   constant                            #constExp
    |   ID                                  #idExp
    |   LPAREN expression RPAREN            #parenExp
    |   addOp                               #addExp
    |   expression cmpOp expression         #cmpExp
    |   expression binaryBoolOp expression  #binOpExp
    |   NOT expression                      #notExp
    ;

cmpOp: '==' | '!=' | '<' | '>' | '>=' | '<=';

// boolOp
//     :
//         not                    
//     |   boolOp binaryBoolOp boolOp      
//     |   bool                 
//     |   LPAREN boolOp RPAREN
//     |   expression  
//     ;
binaryBoolOp: AND | OR;
AND: 'and';
OR: 'or';
NOT: '!';

addOp: multOp ( ARITHMETIC multOp )*;

ARITHMETIC: '+' | '-' | '*' | '/';

multOp: atomExp (ARITHMETIC atomExp)*;
// MULT: '*';
// DIV: '/';

atomExp
    :    constant
    |    ID
    |    LPAREN addOp RPAREN
    ;

assignment
    : ID ASSIGN expression;

ASSIGN: '=';

constant: INT | FLOAT | BOOL | STRING | NULL;
type: INT_TYPE | FLOAT_TYPE | BOOL_TYPE | STRING_TYPE;

INT: ('0'..'9')+;
FLOAT: ('0'..'9')+ ('.' ('0'..'9')+)?;
BOOL: 'true' | 'false';
STRING: '"' ( ~[\\"\r\n] )* '"';
NULL: 'null';
// ID: [a-z]+;
INT_TYPE: 'int';
FLOAT_TYPE: 'float';
BOOL_TYPE: 'bool';
STRING_TYPE: 'string';

ID: [a-zA-Z_][a-zA-Z_]*;

/* We're going to ignore all white space characters */
WS  
    :   (' ' | '\t')+ -> skip;