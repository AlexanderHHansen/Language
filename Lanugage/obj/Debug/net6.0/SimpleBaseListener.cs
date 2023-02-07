﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ax111\Documents\PersonalDocuments\Coding\C#\Language\Lanugage\Content\Simple.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Lanugage.Content {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISimpleListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class SimpleBaseListener : ISimpleListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>exprParen</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprParen([NotNull] SimpleParser.ExprParenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprParen</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprParen([NotNull] SimpleParser.ExprParenContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprConst</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprConst([NotNull] SimpleParser.ExprConstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprConst</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprConst([NotNull] SimpleParser.ExprConstContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprId([NotNull] SimpleParser.ExprIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprId([NotNull] SimpleParser.ExprIdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprBinaryOp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprBinaryOp([NotNull] SimpleParser.ExprBinaryOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprBinaryOp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprBinaryOp([NotNull] SimpleParser.ExprBinaryOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprNot([NotNull] SimpleParser.ExprNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprNot([NotNull] SimpleParser.ExprNotContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprCmp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprCmp([NotNull] SimpleParser.ExprCmpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprCmp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprCmp([NotNull] SimpleParser.ExprCmpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAnd([NotNull] SimpleParser.ExprAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAnd([NotNull] SimpleParser.ExprAndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOr([NotNull] SimpleParser.ExprOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOr([NotNull] SimpleParser.ExprOrContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] SimpleParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] SimpleParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statementOrNewline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementOrNewline([NotNull] SimpleParser.StatementOrNewlineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statementOrNewline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementOrNewline([NotNull] SimpleParser.StatementOrNewlineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] SimpleParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] SimpleParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.newline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewline([NotNull] SimpleParser.NewlineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.newline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewline([NotNull] SimpleParser.NewlineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoop([NotNull] SimpleParser.LoopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoop([NotNull] SimpleParser.LoopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.whileLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileLoop([NotNull] SimpleParser.WhileLoopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.whileLoop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileLoop([NotNull] SimpleParser.WhileLoopContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrint([NotNull] SimpleParser.PrintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.print"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrint([NotNull] SimpleParser.PrintContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] SimpleParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] SimpleParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.cmpOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCmpOp([NotNull] SimpleParser.CmpOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.cmpOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCmpOp([NotNull] SimpleParser.CmpOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] SimpleParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] SimpleParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] SimpleParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] SimpleParser.ConstantContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] SimpleParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] SimpleParser.TypeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Lanugage.Content
