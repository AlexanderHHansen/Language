//------------------------------------------------------------------------------
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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISimpleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>exprParen</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprParen([NotNull] SimpleParser.ExprParenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprParen</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprParen([NotNull] SimpleParser.ExprParenContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprConst</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprConst([NotNull] SimpleParser.ExprConstContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprConst</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprConst([NotNull] SimpleParser.ExprConstContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprId([NotNull] SimpleParser.ExprIdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprId</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprId([NotNull] SimpleParser.ExprIdContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprBinaryOp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprBinaryOp([NotNull] SimpleParser.ExprBinaryOpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprBinaryOp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprBinaryOp([NotNull] SimpleParser.ExprBinaryOpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprNot([NotNull] SimpleParser.ExprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprNot([NotNull] SimpleParser.ExprNotContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprCmp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprCmp([NotNull] SimpleParser.ExprCmpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprCmp</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprCmp([NotNull] SimpleParser.ExprCmpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAnd([NotNull] SimpleParser.ExprAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAnd([NotNull] SimpleParser.ExprAndContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOr([NotNull] SimpleParser.ExprOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOr([NotNull] SimpleParser.ExprOrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] SimpleParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] SimpleParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statementOrNewline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementOrNewline([NotNull] SimpleParser.StatementOrNewlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statementOrNewline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementOrNewline([NotNull] SimpleParser.StatementOrNewlineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] SimpleParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] SimpleParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewline([NotNull] SimpleParser.NewlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewline([NotNull] SimpleParser.NewlineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl([NotNull] SimpleParser.DeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl([NotNull] SimpleParser.DeclContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoop([NotNull] SimpleParser.LoopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoop([NotNull] SimpleParser.LoopContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.whileLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileLoop([NotNull] SimpleParser.WhileLoopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.whileLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileLoop([NotNull] SimpleParser.WhileLoopContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint([NotNull] SimpleParser.PrintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint([NotNull] SimpleParser.PrintContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SimpleParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SimpleParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.cmpOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCmpOp([NotNull] SimpleParser.CmpOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.cmpOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCmpOp([NotNull] SimpleParser.CmpOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] SimpleParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] SimpleParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] SimpleParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] SimpleParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] SimpleParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] SimpleParser.TypeContext context);
}
} // namespace Lanugage.Content
