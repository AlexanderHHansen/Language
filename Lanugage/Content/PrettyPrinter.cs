using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanugage.Content
{
    public class PrettyPrinter : SimpleBaseVisitor<int?>
    {
        private readonly string _newLine = "\n";
        private readonly string _indent = "    ";
        public StringBuilder PrintOutput { get; set; }

        public PrettyPrinter()
        {
            PrintOutput = new StringBuilder();
        }

        //public override int? VisitIdExp(SimpleParser.ExperIdContext context)
        //{
        //    Append(context.ID().GetText());
        //    return null;
        //}

        public override int? VisitExprId(SimpleParser.ExprIdContext context)
        {
            Append(context.ID().GetText());
            return null;
        }

        public override int? VisitExprParen(SimpleParser.ExprParenContext context)
        {
            Append(context.LPAREN().GetText());
            Visit(context.expr());
            Append(context.RPAREN().GetText());
            return null;
        }

        public override int? VisitProgram([NotNull] SimpleParser.ProgramContext context)
        {
            Append("Program start!: "+_newLine);
            VisitChildren(context);
            return null;
        }

        public override int? VisitStatement(SimpleParser.StatementContext context)
        {
            VisitChildren(context);
            NewLine();
            return null;
        }

        public override int? VisitPrint(SimpleParser.PrintContext context)
        {
            Append("print");
            Append(context.LPAREN().GetText());
            Visit(context.expr());
            Append(context.RPAREN().GetText());
            return null;
        }

        public override int? VisitWhileLoop(SimpleParser.WhileLoopContext context)
        {
            Append("while ");
            Visit(context.expr());
            Append(context.LBRACKET().GetText());
            NewLine();
            foreach (var c in context.statementOrNewline())
            {
                if (c.statement() != null)
                {
                    Indent();
                }
                Visit(c);
            }
            Append(context.RBRACKET().GetText());
            return null;
        }

        public override int? VisitExprAnd(SimpleParser.ExprAndContext context)
        {
            Visit(context.left);
            Append($" {context.op.Text} ");
            Visit(context.right);
            return null;
        }

        public override int? VisitExprOr(SimpleParser.ExprOrContext context)
        {
            Visit(context.left);
            Append($" {context.op.Text} ");
            Visit(context.right);
            return null;
        }

        public override int? VisitConstant(SimpleParser.ConstantContext context)
        {
            Append(context.GetText());
            return null;
        }

        public override int? VisitExprCmp(SimpleParser.ExprCmpContext context)
        {
            Visit(context.left);
            Visit(context.op);
            Visit(context.right);
            return null;
        }

        public override int? VisitCmpOp(SimpleParser.CmpOpContext context)
        {
            Append($" {context.GetText()} ");
            return null;
        }

        public override int? VisitExprNot(SimpleParser.ExprNotContext context)
        {
            Append(context.NOT().GetText());
            Visit(context.expr());
            return null;
        }

        public override int? VisitExprBinaryOp(SimpleParser.ExprBinaryOpContext context)
        {
            Visit(context.left);
            Append(context.op.Text);
            Visit(context.right);
            return null;
        }

        public override int? VisitAssignment(SimpleParser.AssignmentContext context)
        {
            Append(context.ID().GetText());
            Append(" = ");
            Visit(context.expr());
            return null;
        }

        public override int? VisitType(SimpleParser.TypeContext context)
        {
            Append(context.GetText());
            return null;
        }

        private void Indent() => PrintOutput.Append(_indent);
        private void NewLine() => PrintOutput.Append(_newLine);
        private void Append(string text) => PrintOutput.Append(text);
        public override string ToString() => PrintOutput.ToString();
    }
}
