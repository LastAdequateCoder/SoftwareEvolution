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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="cobolParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IcobolListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] cobolParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] cobolParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.identification_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentification_division([NotNull] cobolParser.Identification_divisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.identification_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentification_division([NotNull] cobolParser.Identification_divisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.data_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterData_division([NotNull] cobolParser.Data_divisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.data_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitData_division([NotNull] cobolParser.Data_divisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.variables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariables([NotNull] cobolParser.VariablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.variables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariables([NotNull] cobolParser.VariablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLevel([NotNull] cobolParser.LevelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLevel([NotNull] cobolParser.LevelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.picture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPicture([NotNull] cobolParser.PictureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.picture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPicture([NotNull] cobolParser.PictureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.like"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLike([NotNull] cobolParser.LikeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.like"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLike([NotNull] cobolParser.LikeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.procedure_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_division([NotNull] cobolParser.Procedure_divisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.procedure_division"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_division([NotNull] cobolParser.Procedure_divisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing([NotNull] cobolParser.UsingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing([NotNull] cobolParser.UsingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUse([NotNull] cobolParser.UseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.use"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUse([NotNull] cobolParser.UseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.sentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSentence([NotNull] cobolParser.SentenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.sentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSentence([NotNull] cobolParser.SentenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] cobolParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] cobolParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.display"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisplay([NotNull] cobolParser.DisplayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.display"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisplay([NotNull] cobolParser.DisplayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd([NotNull] cobolParser.AddContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd([NotNull] cobolParser.AddContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.accept"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccept([NotNull] cobolParser.AcceptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.accept"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccept([NotNull] cobolParser.AcceptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.withnoadvancing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithnoadvancing([NotNull] cobolParser.WithnoadvancingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.withnoadvancing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithnoadvancing([NotNull] cobolParser.WithnoadvancingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.atomic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtomic([NotNull] cobolParser.AtomicContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.atomic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtomic([NotNull] cobolParser.AtomicContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.giving"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGiving([NotNull] cobolParser.GivingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.giving"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGiving([NotNull] cobolParser.GivingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="cobolParser.identifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifiers([NotNull] cobolParser.IdentifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="cobolParser.identifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifiers([NotNull] cobolParser.IdentifiersContext context);
}
