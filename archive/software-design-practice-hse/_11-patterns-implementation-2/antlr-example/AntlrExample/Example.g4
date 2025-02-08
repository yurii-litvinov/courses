grammar Example;

expression
   : expression  ('+' | '-') expression  # BinOpExpr
   | NUMBER                              # NumberExpr
   ;

NUMBER : ('0'..'9')+;

WS
   : [ \r\n\t] + -> skip
   ;