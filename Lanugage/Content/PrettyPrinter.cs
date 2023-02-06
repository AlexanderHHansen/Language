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

        public override int? VisitExpression(SimpleParser.ExpressionContext context)
        {
            VisitChildren(context);
            return null;
        }

        public override int? VisitIdExp(SimpleParser.IdExpContext context)
        {
            Append(context.ID().GetText());
            return null;
        }

        public override int? VisitParenExp(SimpleParser.ParenExpContext context)
        {
            Append(context.LPAREN().GetText());
            Visit(context.expression());
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

        //public override int? VisitNewline(SimpleParser.NewlineContext context)
        //{
        //    return base.VisitNewline(context);
        //}

        public override int? VisitPrint(SimpleParser.PrintContext context)
        {
            Append("print");
            Append(context.LPAREN().GetText());
            Visit(context.expression());
            Append(context.RPAREN().GetText());
            return null;
        }

        public override int? VisitWhileLoop(SimpleParser.WhileLoopContext context)
        {
            Append("while ");
            Visit(context.expression());
            Append(context.LBRACKET().GetText());
            //NewLine();
            foreach (var c in context.statement())
            {
                Indent();
                Visit(c);
            }
            Append(context.RBRACKET().GetText());
            return null;
        }

        public override int? VisitBinaryBoolOp(SimpleParser.BinaryBoolOpContext context)
        {
            Append($" {context.GetText()} ");
            return null;
        }

        public override int? VisitConstant(SimpleParser.ConstantContext context)
        {
            Append(context.GetText());
            return null;
        }


        public override int? VisitCmpExp(SimpleParser.CmpExpContext context)
        {
            Append(context.GetText());
            return null;
        }

        public override int? VisitNotExp(SimpleParser.NotExpContext context)
        {
            Append(context.NOT().GetText());
            Visit(context.expression());
            return null;
        }

        public override int? VisitAddOp(SimpleParser.AddOpContext context)
        {
            Visit(context.multOp()[0]);
            if (context.multOp().Length > 1)
            {
                for (int i = 1; i < context.multOp().Length; i++)
                {
                    Append(context.ARITHMETIC()[i-1].GetText());
                    Visit(context.multOp()[i]);
                }
            }
            return null;
        }

        public override int? VisitMultOp(SimpleParser.MultOpContext context)
        {
            //Console.WriteLine($"\nmult op atomCount: {context.atomExp().Length} | arithm count: {context.ARITHMETIC().Length}\n");
            Visit(context.atomExp()[0]);
            if (context.atomExp().Length > 1)
            {
                for (int i = 1; i < context.atomExp().Length; i++)
                {
                    Append(context.ARITHMETIC()[i-1].GetText());
                    Visit(context.atomExp()[i]);
                }
            }
            return null;
        }

        public override int? VisitAtomExp(SimpleParser.AtomExpContext context)
        {
            VisitChildren(context);
            return null;
        }

        public override int? VisitAssignment(SimpleParser.AssignmentContext context)
        {
            Append(context.ID().GetText());
            Append(" = ");
            Visit(context.expression());
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
