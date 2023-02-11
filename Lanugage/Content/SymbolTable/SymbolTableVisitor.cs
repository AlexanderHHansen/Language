using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Lanugage.Content.Exceptions;
using Lanugage.Content.SymbolTable;
using static System.Formats.Asn1.AsnWriter;

namespace Lanugage.Content
{
    public class SymbolTableVisitor : SimpleBaseVisitor<object?>
    {
        // https://pages.cs.wisc.edu/~fischer/cs536.s08/course.hold/html/NOTES/6.SYMBOL-TABLES.html
        // https://github.com/humleflue/P4/blob/master/ANTLR/src/Compiler/SymbolTableGenerator/SymbolTableGeneratorListener.java
        // use ErrorHandler instead of throwing exceptions

        public ParseTreeProperty<IScope> Scopes; // Only used for functions...
        public IScope CurrentScope { get; set; }


        public SymbolTableVisitor()
        {
            Scopes = new ParseTreeProperty<IScope>();
            CurrentScope = new BaseScope();
        }

        public override object VisitWhileLoop(SimpleParser.WhileLoopContext context)
        {
            Visit(context.expr());
            EnterScope();
            foreach (var statement in context.statementOrNewline())
            {
                Visit(statement);
            }
            ExitScope();
            return null;
        }

        public override object VisitExprId(SimpleParser.ExprIdContext context)
        {
            string name = context.ID().GetText();
            Symbol? s = CurrentScope.GetSymbol(name);
            if (s == null)
            {
                int lineNumber = context.start.Line;
                throw new UndeclaredVariableException($"{name} on line {lineNumber} is not defined!");
            }
            Scopes.Put(context, CurrentScope);
            return null;
        }

        public override object VisitAssignment(SimpleParser.AssignmentContext context)
        {
            Visit(context.expr());
            string name = context.ID().GetText();
            Symbol s = new Symbol(context.ID().GetText(), null);
            CurrentScope.DefineSymbol(s);
            ContextToScopeAssociation(context, CurrentScope);
            return null;
        }

        private void EnterScope()
        {
            BaseScope scope = new BaseScope(CurrentScope);
            CurrentScope = scope;
        }

        private void ExitScope()
        {
            CurrentScope = CurrentScope.EnclosingScope;
        }

        private void ContextToScopeAssociation(ParserRuleContext ctx, IScope s)
        {
            Scopes.Put(ctx, s);
        }
    }
}
