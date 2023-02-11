using Antlr4.Runtime.Tree;
using Lanugage.Content.SymbolTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lanugage.Content.Exceptions;


namespace Lanugage.Content
{
    public class TypeCheckingVisitor : SimpleBaseVisitor<int>
    {
        public ParseTreeProperty<IScope> Scopes { get; set; }
        public IScope CurrentScope { get; set; }

        public TypeCheckingVisitor(ParseTreeProperty<IScope> scopes, IScope scope)
        {
            CurrentScope = scope;
            Scopes = scopes;
        }

        public override int VisitAssignment(SimpleParser.AssignmentContext context)
        {
            string idName = context.ID().GetText();
            var scope = Scopes.Get(context);
            var symbol = scope.GetSymbol(idName);
            if (symbol.Type == null) // ie. declaration
            {   // update exprType for variable
                var type = Visit(context.expr());
                scope.UpdateSymbolType(idName, type);
                return type;
            }
            else // assignment of new value to existing variable 
            {
                int type = Visit(context.expr());
                if (!AssignmentCompatibility((int)symbol.Type, type))
                {
                    throw new TypeCheckException($"Invalid assignment on line: {context.start.Line}\n Cannot assign a value of type {TypeToString(type)} to {TypeToString((int) symbol.Type)}");
                }
            }

            return (int)symbol.Type; 
        }

        public override int VisitExprParen(SimpleParser.ExprParenContext context)
        {
            return Visit(context.expr());
        }

        private bool AssignmentCompatibility(int symbolType, int exprType)
        {
            // check if assignment is legal
            if (symbolType == exprType)
            {
                return true;
            }
            if (symbolType == SimpleLexer.FLOAT && exprType == SimpleLexer.INT)
            {
                return true;
            }

            return false;
        }

        public override int VisitExprId(SimpleParser.ExprIdContext context)
        {
            var scope = Scopes.Get(context);
            Symbol s = scope.GetSymbol(context.ID().GetText());
            return (int)s.Type;
        }

        public override int VisitExprBinaryOp(SimpleParser.ExprBinaryOpContext context)
        {
            int lType = Visit(context.left);
            int rType = Visit(context.right);
            switch (context.op.Type)
            {
                case SimpleLexer.ADD:
                    HandleAddSub(lType, rType, context);
                    break;
                case SimpleLexer.MINUS:
                    HandleAddSub(lType, rType, context);
                    break;
                case SimpleLexer.MULT:
                    HandleMultDiv(lType, rType, context);
                    break;
                case SimpleLexer.DIV:
                    HandleMultDiv(lType, rType, context);
                    break;
            }
            return LargestType(lType, rType);
        }

        private int LargestType(int lType, int rType)
        {
            if (lType == SimpleLexer.FLOAT || rType == SimpleLexer.FLOAT) return SimpleLexer.FLOAT;
            return SimpleParser.INT;
        }

        private void HandleMultDiv(int lType, int rType, SimpleParser.ExprBinaryOpContext context)
        {   // currently same rules as for add and sub, might change
            HandleAddSub(lType, rType, context);
        }

        private void HandleAddSub(int lType, int rType, SimpleParser.ExprBinaryOpContext context)
        {
            if ((lType == SimpleLexer.INT || lType == SimpleLexer.FLOAT) && 
                (rType == SimpleLexer.INT || rType == SimpleLexer.FLOAT)) return;

            //if (lType == SimpleLexer.STRING && rType == SimpleLexer.STRING) return;
            throw new TypeCheckException(
                $"Invalid arithmetic operation with expressions of type {TypeToString(lType)} and {TypeToString(rType)} on line {context.start.Line}.\n" +
                $"expressions must be of type int or float");
        }

        public override int VisitConstant(SimpleParser.ConstantContext context)
        {
            if (context.INT() != null) return SimpleLexer.INT;
            else if (context.FLOAT() != null) return SimpleLexer.FLOAT;
            else if (context.BOOL() != null) return SimpleLexer.BOOL;
            else if (context.STRING() != null) return SimpleLexer.STRING;
            else if (context.NULL() != null) return SimpleLexer.NULL;
            else throw new Exception("something went wrong...");
        }

        public override int VisitExprConst(SimpleParser.ExprConstContext context)
        {
            return Visit(context.constant());
        }

        public override int VisitExprNot(SimpleParser.ExprNotContext context)
        {
            int type = Visit(context.expr());
            if (type != SimpleLexer.BOOL)
            {
                throw new TypeCheckException($"Invalid use of not operator on line: {context.start.Line}\n" +
                                             $"Cannot use \"!\" operator on expression of type {TypeToString(type)}");
            }

            return type;
        }

        public override int VisitExprAnd(SimpleParser.ExprAndContext context)
        {
            int lType = Visit(context.left);
            int rType = Visit(context.right);
            if (lType != SimpleLexer.BOOL || rType != SimpleLexer.BOOL)
            {
                throw new TypeCheckException(
                    $"Invalid \"and\" expression with expressions of type {TypeToString(lType)} and {TypeToString(rType)} on line {context.start.Line}" +
                    $"\n Expressions must both be of type bool");
            }

            return SimpleLexer.BOOL;
        }

        public override int VisitExprOr(SimpleParser.ExprOrContext context)
        {
            int lType = Visit(context.left);
            int rType = Visit(context.right);
            if (lType != SimpleLexer.BOOL || rType != SimpleLexer.BOOL)
            {
                throw new TypeCheckException(
                    $"Invalid \"or\" expression with expressions of type {TypeToString(lType)} and {TypeToString(rType)} on line {context.start.Line}" +
                    $"\n Expressions must both be of type bool");
            }

            return SimpleLexer.BOOL;
        }


        public override int VisitExprCmp(SimpleParser.ExprCmpContext context)
        {
            int lType = Visit(context.left);
            int rType = Visit(context.right);
            if (lType != rType)
                throw new TypeCheckException(
                    $"Invalid comparison with expressions of type {TypeToString(lType)} and {TypeToString(rType)} on line {context.start.Line}\n" +
                    "expressions must be of the same type.");
            return SimpleLexer.BOOL;
        }

        public override int VisitWhileLoop(SimpleParser.WhileLoopContext context)
        {
            int conditionType = Visit(context.expr());
            if (conditionType != SimpleLexer.BOOL)
            {
                throw new TypeCheckException(
                    $"Invalid while loop condition of type {TypeToString(conditionType)} on line {context.start.Line}\n" +
                    "expressions must be of type bool.");
            }
            foreach (var statement in context.statementOrNewline())
            {
                Visit(statement);
            }
            return SimpleLexer.WHILE;
        }

        private string TypeToString(int type)
        {
            switch (type)
            {
                case SimpleLexer.INT: return "int";
                case SimpleLexer.FLOAT: return "float";
                case SimpleLexer.BOOL: return "bool";
                case SimpleLexer.STRING: return "string";
                case SimpleLexer.NULL: return "null";
                default: throw new Exception($"invalid parameter of type {type}");
            }
        }
    }
}
