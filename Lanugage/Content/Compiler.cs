using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Lanugage.Content;
using Lanugage.Content.ErrorHandeling;
using Lanugage.Content.SymbolTable;

try
{
    var filename = "Content/SimpleScript.ss";
    var fileContents = File.ReadAllText(filename);
    var inputStream = new AntlrInputStream(fileContents);
    var lexer = new SimpleLexer(inputStream);
    CommonTokenStream cts = new CommonTokenStream(lexer);
    lexer.RemoveErrorListeners();
    lexer.AddErrorListener(new LexerErrorListener());
    var parser = new SimpleParser(cts);
    parser.RemoveErrorListeners();
    parser.AddErrorListener(new SimpleErrorListener());
    parser.ErrorHandler = new StrictErrorStrategy();
    var context = parser.program();
    var prettyPrinter = new PrettyPrinter();
    prettyPrinter.VisitProgram(context);
    Console.WriteLine(prettyPrinter.ToString());
}
catch (ParseCanceledException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
