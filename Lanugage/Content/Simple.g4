grammar Simple;

program: statementOrNewline* EOF;

statementOrNewline: statement | newline;

statement: 
        (expr
    |   assignment
    |   loop
    |   print) newline;

newline: ('\n' | '\r')+;

loop: whileLoop;

whileLoop: WHILE expr LBRACKET (statementOrNewline)* RBRACKET;
WHILE: 'while';
LBRACKET: '{';
RBRACKET: '}';

print: PRINT LPAREN expr RPAREN;
PRINT: 'print';
LPAREN: '(';
RPAREN: ')';

expr
    :   LPAREN expr RPAREN                     #exprParen
    |   constant                               #exprConst
    |   ID                                     #exprId
    |   left=expr op=(DIV|MULT) right=expr     #exprBinaryOp
    |   left=expr op=(ADD|MINUS) right=expr    #exprBinaryOp    
    |   NOT expr                               #exprNot
    |   left=expr op=cmpOp right=expr          #exprCmp
    |   left=expr op=AND right=expr            #exprAnd
    |   left=expr op=OR right=expr             #exprOr
    ;

cmpOp: '==' | '!=' | '<' | '>' | '>=' | '<=';

assignment
    : ID ASSIGN expr;

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
AND: 'and';
OR: 'or';
NOT: '!';
ADD: '+';
MINUS: '-';

MULT: '*';
DIV: '/';


ID: [a-zA-Z_][a-zA-Z_]*;

/* We're going to ignore all white space characters */
WS  
    :   (' ' | '\t')+ -> skip;