using Antlr4.Runtime.Tree;
using Lanugage.Content.SymbolTable;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content
{
    public class CCodeGenerator : SimpleBaseVisitor<object>
    {
        private ParseTreeProperty<IScope> Scopes { get; set; }
        private IScope CurrentScope { get; set; }
        private StringBuilder CodeBuilder { get; set; }
        private TypeCheckingVisitor TypeChecker { get; set; }
        private string OutputPath { get; set; }

        public CCodeGenerator(ParseTreeProperty<IScope> scopes, IScope scope, string outputPath, TypeCheckingVisitor tcv)
        {
            Scopes = scopes; // need to know type for certain code
            CurrentScope = scope;
            CodeBuilder = new StringBuilder();
            OutputPath = outputPath;
            TypeChecker = tcv;
        }

        public override object VisitProgram(SimpleParser.ProgramContext context)
        {
            AppendWithNewline("#include <stdio.h>");
            AppendWithNewline("#include <string.h>");
            AppendWithNewline("#include <stdlib.h>");
            AppendWithNewline("#include <math.h>");
            AppendWithNewline("char* bool_to_str(int bool) { return bool == 1 ? \"true\" : \"false\"; }");

            AppendWithNewline("int main() {");

            VisitChildren(context);

            Indent();
            AppendWithNewline("return 0;");
            Append("}");
            return null;
        }

        public override object VisitStatement(SimpleParser.StatementContext context)
        {
            Indent();
            VisitChildren(context);
            SemiColon();
            Newline();
            return null;
        }

        public override object VisitPrint(SimpleParser.PrintContext context)
        {
            int type = TypeChecker.Visit(context.expr());

            string format = PrintfFormat(type);

            if (type == SimpleLexer.BOOL)
            {
                Append( $"printf(\"{format}\\n\", bool_to_str(");
                Visit(context.expr());
                AppendWithNewline($"))");
            }
            else
            {
                Append($"printf(\"{format}\\n\", ");
                Visit(context.expr());
                Append($")");
            }

            return null;
        }

        private string PrintfFormat(int type)
        {
            switch (type)
            {
                case SimpleLexer.INT: return "%d";
                case SimpleLexer.FLOAT: return "%lf";
                case SimpleLexer.BOOL: return "%s";
                case SimpleLexer.STRING: return "%s";
                case SimpleLexer.NULL: return "%s";
                default: throw new Exception($"invalid parameter of type {type}");
            }
        }

        public override object VisitAssignment(SimpleParser.AssignmentContext context)
        {
            Append($"{context.ID().GetText()} = ");
            Visit(context.expr());
            return null;
        }

        public override object VisitDecl(SimpleParser.DeclContext context)
        {
            string idName = context.ID().GetText();
            var scope = Scopes.Get(context);
            var symbol = scope.GetSymbol(idName);

            string cType = TypeToCType((int)symbol.Type);
            Append($"{cType} {context.ID().GetText()} = ");
            Visit(context.expr());
            return null;
        }

        public override object VisitExprParen(SimpleParser.ExprParenContext context)
        {
            Append("(");
            Visit(context.expr());
            Append(")");
            return null;
        }

        public override object VisitExprId(SimpleParser.ExprIdContext context)
        {
            Append(context.GetText());
            return null;
        }

        public override object VisitExprBinaryOp(SimpleParser.ExprBinaryOpContext context)
        {
            Visit(context.left);
            Append(context.op.Text);
            Visit(context.right);
            return null;
        }

        public override object VisitExprNot(SimpleParser.ExprNotContext context)
        {
            Append("!");
            Visit(context.expr());
            return null;
        }

        public override object VisitExprCmp(SimpleParser.ExprCmpContext context)
        {
            Visit(context.left);
            Visit(context.op);
            Visit(context.right);
            return null;
        }

        public override object VisitCmpOp(SimpleParser.CmpOpContext context)
        {
            Append($" {context.GetText()} ");
            return null;
        }

        public override object VisitExprAnd(SimpleParser.ExprAndContext context)
        {
            Visit(context.left);
            Append(" && ");
            Visit(context.right);
            return null;
        }

        public override object VisitExprOr(SimpleParser.ExprOrContext context)
        {
            Visit(context.left);
            Append(" || ");
            Visit(context.right);
            return null;
        }

        public override object VisitConstant(SimpleParser.ConstantContext context)
        {
            if (context.BOOL() != null)
            {
                Append(context.BOOL().GetText() == "true" ? "1" : "0");
            }
            else if (context.NULL() != null)
            {
                Append("NULL");
            }
            else
            {
                Append(context.GetText());
            }

            return null;
        }

        private string TypeToCType(int type)
        {
            switch (type)
            {
                case SimpleLexer.INT: return "int";
                case SimpleLexer.FLOAT: return "double";
                case SimpleLexer.BOOL: return "int";
                case SimpleLexer.STRING: return "char*";
                case SimpleLexer.NULL: return "char*";
                default: throw new Exception($"invalid parameter of type {type}");
            }
        }

        public override object VisitWhileLoop(SimpleParser.WhileLoopContext context)
        {
            Append("while (");
            Visit(context.expr()); // condition
            AppendWithNewline(") {");
            foreach (var c in context.statementOrNewline())
            {
                if (c.statement() != null) // don't care about newlines
                {
                    Indent();
                    Visit(c);
                }
            }
            Indent();
            Append("}");
            return null;
        }

        void Indent() => CodeBuilder.Append("\t");
        void Newline() => CodeBuilder.AppendLine();
        void Append(string text) => CodeBuilder.Append(text);
        void AppendWithNewline(string text) => CodeBuilder.AppendLine(text);
        void SemiColon() => CodeBuilder.Append(";");
        public override string ToString() => CodeBuilder.ToString();

        public void WriteToFile()
        {
            File.WriteAllText("C:\\Users\\ax111\\Downloads\\simple.c", ToString());
        }

        private string TypeToString(int type)
        {
            switch (type)
            {
                case SimpleLexer.INT: return "int";
                case SimpleLexer.FLOAT: return "double";
                case SimpleLexer.BOOL: return "int";
                case SimpleLexer.STRING: return "char*";
                case SimpleLexer.NULL: return "NULL";
                default: throw new Exception($"invalid parameter of type {type}");
            }
        }


    }
}
