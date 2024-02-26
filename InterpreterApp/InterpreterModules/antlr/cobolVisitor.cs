//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from cobol.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="cobolParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IcobolVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] cobolParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.identification_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentification_division([NotNull] cobolParser.Identification_divisionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.data_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitData_division([NotNull] cobolParser.Data_divisionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.picture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPicture([NotNull] cobolParser.PictureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.like"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLike([NotNull] cobolParser.LikeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.procedure_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedure_division([NotNull] cobolParser.Procedure_divisionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsing([NotNull] cobolParser.UsingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUse([NotNull] cobolParser.UseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.sentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSentence([NotNull] cobolParser.SentenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] cobolParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.display"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplay([NotNull] cobolParser.DisplayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.withnoadvancing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWithnoadvancing([NotNull] cobolParser.WithnoadvancingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.atomic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtomic([NotNull] cobolParser.AtomicContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="cobolParser.identifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifiers([NotNull] cobolParser.IdentifiersContext context);
}