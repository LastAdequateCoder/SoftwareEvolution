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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class cobolLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, REPRESENTATION=3, IDENTIFICATION=4, DIVISION=5, OCCURS=6, 
		TIMES=7, PICTURE=8, IS=9, PROCEDURE=10, USING=11, BY=12, REFERENCE=13, 
		CONTENT=14, VALUE=15, LIKE=16, DISPLAY=17, OF=18, WITH=19, NO=20, ADVANCING=21, 
		DATA=22, ADD=23, TO=24, GIVING=25, ACCEPT=26, MULTIPLY=27, IDENTIFIER=28, 
		INT=29, SPACE=30, DOT=31, LITERAL=32;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "REPRESENTATION", "IDENTIFICATION", "DIVISION", "OCCURS", 
		"TIMES", "PICTURE", "IS", "PROCEDURE", "USING", "BY", "REFERENCE", "CONTENT", 
		"VALUE", "LIKE", "DISPLAY", "OF", "WITH", "NO", "ADVANCING", "DATA", "ADD", 
		"TO", "GIVING", "ACCEPT", "MULTIPLY", "IDENTIFIER", "INT", "SPACE", "DOT", 
		"LITERAL", "LETTER", "DIGIT", "REPR"
	};


	public cobolLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public cobolLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "REPRESENTATION", "IDENTIFICATION", "DIVISION", "OCCURS", 
		"TIMES", "PICTURE", "IS", "PROCEDURE", "USING", "BY", "REFERENCE", "CONTENT", 
		"VALUE", "LIKE", "DISPLAY", "OF", "WITH", "NO", "ADVANCING", "DATA", "ADD", 
		"TO", "GIVING", "ACCEPT", "MULTIPLY", "IDENTIFIER", "INT", "SPACE", "DOT", 
		"LITERAL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "cobol.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static cobolLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,32,952,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,1,0,1,
		0,1,1,1,1,1,2,4,2,77,8,2,11,2,12,2,78,1,3,1,3,5,3,83,8,3,10,3,12,3,86,
		9,3,1,3,1,3,5,3,90,8,3,10,3,12,3,93,9,3,1,3,1,3,5,3,97,8,3,10,3,12,3,100,
		9,3,1,3,1,3,5,3,104,8,3,10,3,12,3,107,9,3,1,3,1,3,5,3,111,8,3,10,3,12,
		3,114,9,3,1,3,1,3,5,3,118,8,3,10,3,12,3,121,9,3,1,3,1,3,5,3,125,8,3,10,
		3,12,3,128,9,3,1,3,1,3,5,3,132,8,3,10,3,12,3,135,9,3,1,3,1,3,5,3,139,8,
		3,10,3,12,3,142,9,3,1,3,1,3,5,3,146,8,3,10,3,12,3,149,9,3,1,3,1,3,5,3,
		153,8,3,10,3,12,3,156,9,3,1,3,1,3,5,3,160,8,3,10,3,12,3,163,9,3,1,3,1,
		3,5,3,167,8,3,10,3,12,3,170,9,3,1,3,1,3,1,4,1,4,5,4,176,8,4,10,4,12,4,
		179,9,4,1,4,1,4,5,4,183,8,4,10,4,12,4,186,9,4,1,4,1,4,5,4,190,8,4,10,4,
		12,4,193,9,4,1,4,1,4,5,4,197,8,4,10,4,12,4,200,9,4,1,4,1,4,5,4,204,8,4,
		10,4,12,4,207,9,4,1,4,1,4,5,4,211,8,4,10,4,12,4,214,9,4,1,4,1,4,5,4,218,
		8,4,10,4,12,4,221,9,4,1,4,1,4,1,5,1,5,5,5,227,8,5,10,5,12,5,230,9,5,1,
		5,1,5,5,5,234,8,5,10,5,12,5,237,9,5,1,5,1,5,5,5,241,8,5,10,5,12,5,244,
		9,5,1,5,1,5,5,5,248,8,5,10,5,12,5,251,9,5,1,5,1,5,5,5,255,8,5,10,5,12,
		5,258,9,5,1,5,1,5,1,6,1,6,5,6,264,8,6,10,6,12,6,267,9,6,1,6,1,6,5,6,271,
		8,6,10,6,12,6,274,9,6,1,6,1,6,5,6,278,8,6,10,6,12,6,281,9,6,1,6,1,6,5,
		6,285,8,6,10,6,12,6,288,9,6,1,6,1,6,1,7,1,7,5,7,294,8,7,10,7,12,7,297,
		9,7,1,7,1,7,5,7,301,8,7,10,7,12,7,304,9,7,1,7,1,7,5,7,308,8,7,10,7,12,
		7,311,9,7,1,7,1,7,5,7,315,8,7,10,7,12,7,318,9,7,1,7,1,7,5,7,322,8,7,10,
		7,12,7,325,9,7,1,7,1,7,5,7,329,8,7,10,7,12,7,332,9,7,1,7,1,7,1,8,1,8,5,
		8,338,8,8,10,8,12,8,341,9,8,1,8,1,8,1,9,1,9,5,9,347,8,9,10,9,12,9,350,
		9,9,1,9,1,9,5,9,354,8,9,10,9,12,9,357,9,9,1,9,1,9,5,9,361,8,9,10,9,12,
		9,364,9,9,1,9,1,9,5,9,368,8,9,10,9,12,9,371,9,9,1,9,1,9,5,9,375,8,9,10,
		9,12,9,378,9,9,1,9,1,9,5,9,382,8,9,10,9,12,9,385,9,9,1,9,1,9,5,9,389,8,
		9,10,9,12,9,392,9,9,1,9,1,9,5,9,396,8,9,10,9,12,9,399,9,9,1,9,1,9,1,10,
		1,10,5,10,405,8,10,10,10,12,10,408,9,10,1,10,1,10,5,10,412,8,10,10,10,
		12,10,415,9,10,1,10,1,10,5,10,419,8,10,10,10,12,10,422,9,10,1,10,1,10,
		5,10,426,8,10,10,10,12,10,429,9,10,1,10,1,10,1,11,1,11,5,11,435,8,11,10,
		11,12,11,438,9,11,1,11,1,11,1,12,1,12,5,12,444,8,12,10,12,12,12,447,9,
		12,1,12,1,12,5,12,451,8,12,10,12,12,12,454,9,12,1,12,1,12,5,12,458,8,12,
		10,12,12,12,461,9,12,1,12,1,12,5,12,465,8,12,10,12,12,12,468,9,12,1,12,
		1,12,5,12,472,8,12,10,12,12,12,475,9,12,1,12,1,12,5,12,479,8,12,10,12,
		12,12,482,9,12,1,12,1,12,5,12,486,8,12,10,12,12,12,489,9,12,1,12,1,12,
		5,12,493,8,12,10,12,12,12,496,9,12,1,12,1,12,1,13,1,13,5,13,502,8,13,10,
		13,12,13,505,9,13,1,13,1,13,5,13,509,8,13,10,13,12,13,512,9,13,1,13,1,
		13,5,13,516,8,13,10,13,12,13,519,9,13,1,13,1,13,5,13,523,8,13,10,13,12,
		13,526,9,13,1,13,1,13,5,13,530,8,13,10,13,12,13,533,9,13,1,13,1,13,5,13,
		537,8,13,10,13,12,13,540,9,13,1,13,1,13,1,14,1,14,5,14,546,8,14,10,14,
		12,14,549,9,14,1,14,1,14,5,14,553,8,14,10,14,12,14,556,9,14,1,14,1,14,
		5,14,560,8,14,10,14,12,14,563,9,14,1,14,1,14,5,14,567,8,14,10,14,12,14,
		570,9,14,1,14,1,14,1,15,1,15,5,15,576,8,15,10,15,12,15,579,9,15,1,15,1,
		15,5,15,583,8,15,10,15,12,15,586,9,15,1,15,1,15,5,15,590,8,15,10,15,12,
		15,593,9,15,1,15,1,15,1,16,1,16,5,16,599,8,16,10,16,12,16,602,9,16,1,16,
		1,16,5,16,606,8,16,10,16,12,16,609,9,16,1,16,1,16,5,16,613,8,16,10,16,
		12,16,616,9,16,1,16,1,16,5,16,620,8,16,10,16,12,16,623,9,16,1,16,1,16,
		5,16,627,8,16,10,16,12,16,630,9,16,1,16,1,16,5,16,634,8,16,10,16,12,16,
		637,9,16,1,16,1,16,1,17,1,17,5,17,643,8,17,10,17,12,17,646,9,17,1,17,1,
		17,1,18,1,18,5,18,652,8,18,10,18,12,18,655,9,18,1,18,1,18,5,18,659,8,18,
		10,18,12,18,662,9,18,1,18,1,18,5,18,666,8,18,10,18,12,18,669,9,18,1,18,
		1,18,1,19,1,19,5,19,675,8,19,10,19,12,19,678,9,19,1,19,1,19,1,20,1,20,
		5,20,684,8,20,10,20,12,20,687,9,20,1,20,1,20,5,20,691,8,20,10,20,12,20,
		694,9,20,1,20,1,20,5,20,698,8,20,10,20,12,20,701,9,20,1,20,1,20,5,20,705,
		8,20,10,20,12,20,708,9,20,1,20,1,20,5,20,712,8,20,10,20,12,20,715,9,20,
		1,20,1,20,5,20,719,8,20,10,20,12,20,722,9,20,1,20,1,20,5,20,726,8,20,10,
		20,12,20,729,9,20,1,20,1,20,5,20,733,8,20,10,20,12,20,736,9,20,1,20,1,
		20,1,21,1,21,5,21,742,8,21,10,21,12,21,745,9,21,1,21,1,21,5,21,749,8,21,
		10,21,12,21,752,9,21,1,21,1,21,5,21,756,8,21,10,21,12,21,759,9,21,1,21,
		1,21,1,22,1,22,5,22,765,8,22,10,22,12,22,768,9,22,1,22,1,22,5,22,772,8,
		22,10,22,12,22,775,9,22,1,22,1,22,1,23,1,23,5,23,781,8,23,10,23,12,23,
		784,9,23,1,23,1,23,1,24,1,24,5,24,790,8,24,10,24,12,24,793,9,24,1,24,1,
		24,5,24,797,8,24,10,24,12,24,800,9,24,1,24,1,24,5,24,804,8,24,10,24,12,
		24,807,9,24,1,24,1,24,5,24,811,8,24,10,24,12,24,814,9,24,1,24,1,24,5,24,
		818,8,24,10,24,12,24,821,9,24,1,24,1,24,1,25,1,25,5,25,827,8,25,10,25,
		12,25,830,9,25,1,25,1,25,5,25,834,8,25,10,25,12,25,837,9,25,1,25,1,25,
		5,25,841,8,25,10,25,12,25,844,9,25,1,25,1,25,5,25,848,8,25,10,25,12,25,
		851,9,25,1,25,1,25,5,25,855,8,25,10,25,12,25,858,9,25,1,25,1,25,1,26,1,
		26,5,26,864,8,26,10,26,12,26,867,9,26,1,26,1,26,5,26,871,8,26,10,26,12,
		26,874,9,26,1,26,1,26,5,26,878,8,26,10,26,12,26,881,9,26,1,26,1,26,5,26,
		885,8,26,10,26,12,26,888,9,26,1,26,1,26,5,26,892,8,26,10,26,12,26,895,
		9,26,1,26,1,26,5,26,899,8,26,10,26,12,26,902,9,26,1,26,1,26,5,26,906,8,
		26,10,26,12,26,909,9,26,1,26,1,26,1,27,1,27,1,27,1,27,5,27,917,8,27,10,
		27,12,27,920,9,27,1,27,1,27,1,27,1,27,3,27,926,8,27,1,28,4,28,929,8,28,
		11,28,12,28,930,1,29,1,29,1,29,1,29,1,30,1,30,1,31,1,31,4,31,941,8,31,
		11,31,12,31,942,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,0,0,35,1,1,3,2,
		5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,
		16,33,17,35,18,37,19,39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,
		28,57,29,59,30,61,31,63,32,65,0,67,0,69,0,1,0,27,2,0,73,73,105,105,2,0,
		68,68,100,100,2,0,69,69,101,101,2,0,78,78,110,110,2,0,84,84,116,116,2,
		0,70,70,102,102,2,0,67,67,99,99,2,0,65,65,97,97,2,0,79,79,111,111,2,0,
		86,86,118,118,2,0,83,83,115,115,2,0,85,85,117,117,2,0,82,82,114,114,2,
		0,77,77,109,109,2,0,80,80,112,112,2,0,71,71,103,103,2,0,66,66,98,98,2,
		0,89,89,121,121,2,0,76,76,108,108,2,0,75,75,107,107,2,0,87,87,119,119,
		2,0,72,72,104,104,3,0,9,10,12,13,32,32,1,0,34,34,2,0,65,90,97,122,1,0,
		48,57,11,0,57,57,65,65,83,83,86,86,88,88,90,90,97,97,115,115,118,118,120,
		120,122,122,1067,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,
		0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,
		0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,
		1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,
		0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,
		1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,
		0,1,71,1,0,0,0,3,73,1,0,0,0,5,76,1,0,0,0,7,80,1,0,0,0,9,173,1,0,0,0,11,
		224,1,0,0,0,13,261,1,0,0,0,15,291,1,0,0,0,17,335,1,0,0,0,19,344,1,0,0,
		0,21,402,1,0,0,0,23,432,1,0,0,0,25,441,1,0,0,0,27,499,1,0,0,0,29,543,1,
		0,0,0,31,573,1,0,0,0,33,596,1,0,0,0,35,640,1,0,0,0,37,649,1,0,0,0,39,672,
		1,0,0,0,41,681,1,0,0,0,43,739,1,0,0,0,45,762,1,0,0,0,47,778,1,0,0,0,49,
		787,1,0,0,0,51,824,1,0,0,0,53,861,1,0,0,0,55,912,1,0,0,0,57,928,1,0,0,
		0,59,932,1,0,0,0,61,936,1,0,0,0,63,938,1,0,0,0,65,946,1,0,0,0,67,948,1,
		0,0,0,69,950,1,0,0,0,71,72,5,40,0,0,72,2,1,0,0,0,73,74,5,41,0,0,74,4,1,
		0,0,0,75,77,3,69,34,0,76,75,1,0,0,0,77,78,1,0,0,0,78,76,1,0,0,0,78,79,
		1,0,0,0,79,6,1,0,0,0,80,84,7,0,0,0,81,83,3,59,29,0,82,81,1,0,0,0,83,86,
		1,0,0,0,84,82,1,0,0,0,84,85,1,0,0,0,85,87,1,0,0,0,86,84,1,0,0,0,87,91,
		7,1,0,0,88,90,3,59,29,0,89,88,1,0,0,0,90,93,1,0,0,0,91,89,1,0,0,0,91,92,
		1,0,0,0,92,94,1,0,0,0,93,91,1,0,0,0,94,98,7,2,0,0,95,97,3,59,29,0,96,95,
		1,0,0,0,97,100,1,0,0,0,98,96,1,0,0,0,98,99,1,0,0,0,99,101,1,0,0,0,100,
		98,1,0,0,0,101,105,7,3,0,0,102,104,3,59,29,0,103,102,1,0,0,0,104,107,1,
		0,0,0,105,103,1,0,0,0,105,106,1,0,0,0,106,108,1,0,0,0,107,105,1,0,0,0,
		108,112,7,4,0,0,109,111,3,59,29,0,110,109,1,0,0,0,111,114,1,0,0,0,112,
		110,1,0,0,0,112,113,1,0,0,0,113,115,1,0,0,0,114,112,1,0,0,0,115,119,7,
		0,0,0,116,118,3,59,29,0,117,116,1,0,0,0,118,121,1,0,0,0,119,117,1,0,0,
		0,119,120,1,0,0,0,120,122,1,0,0,0,121,119,1,0,0,0,122,126,7,5,0,0,123,
		125,3,59,29,0,124,123,1,0,0,0,125,128,1,0,0,0,126,124,1,0,0,0,126,127,
		1,0,0,0,127,129,1,0,0,0,128,126,1,0,0,0,129,133,7,0,0,0,130,132,3,59,29,
		0,131,130,1,0,0,0,132,135,1,0,0,0,133,131,1,0,0,0,133,134,1,0,0,0,134,
		136,1,0,0,0,135,133,1,0,0,0,136,140,7,6,0,0,137,139,3,59,29,0,138,137,
		1,0,0,0,139,142,1,0,0,0,140,138,1,0,0,0,140,141,1,0,0,0,141,143,1,0,0,
		0,142,140,1,0,0,0,143,147,7,7,0,0,144,146,3,59,29,0,145,144,1,0,0,0,146,
		149,1,0,0,0,147,145,1,0,0,0,147,148,1,0,0,0,148,150,1,0,0,0,149,147,1,
		0,0,0,150,154,7,4,0,0,151,153,3,59,29,0,152,151,1,0,0,0,153,156,1,0,0,
		0,154,152,1,0,0,0,154,155,1,0,0,0,155,157,1,0,0,0,156,154,1,0,0,0,157,
		161,7,0,0,0,158,160,3,59,29,0,159,158,1,0,0,0,160,163,1,0,0,0,161,159,
		1,0,0,0,161,162,1,0,0,0,162,164,1,0,0,0,163,161,1,0,0,0,164,168,7,8,0,
		0,165,167,3,59,29,0,166,165,1,0,0,0,167,170,1,0,0,0,168,166,1,0,0,0,168,
		169,1,0,0,0,169,171,1,0,0,0,170,168,1,0,0,0,171,172,7,3,0,0,172,8,1,0,
		0,0,173,177,7,1,0,0,174,176,3,59,29,0,175,174,1,0,0,0,176,179,1,0,0,0,
		177,175,1,0,0,0,177,178,1,0,0,0,178,180,1,0,0,0,179,177,1,0,0,0,180,184,
		7,0,0,0,181,183,3,59,29,0,182,181,1,0,0,0,183,186,1,0,0,0,184,182,1,0,
		0,0,184,185,1,0,0,0,185,187,1,0,0,0,186,184,1,0,0,0,187,191,7,9,0,0,188,
		190,3,59,29,0,189,188,1,0,0,0,190,193,1,0,0,0,191,189,1,0,0,0,191,192,
		1,0,0,0,192,194,1,0,0,0,193,191,1,0,0,0,194,198,7,0,0,0,195,197,3,59,29,
		0,196,195,1,0,0,0,197,200,1,0,0,0,198,196,1,0,0,0,198,199,1,0,0,0,199,
		201,1,0,0,0,200,198,1,0,0,0,201,205,7,10,0,0,202,204,3,59,29,0,203,202,
		1,0,0,0,204,207,1,0,0,0,205,203,1,0,0,0,205,206,1,0,0,0,206,208,1,0,0,
		0,207,205,1,0,0,0,208,212,7,0,0,0,209,211,3,59,29,0,210,209,1,0,0,0,211,
		214,1,0,0,0,212,210,1,0,0,0,212,213,1,0,0,0,213,215,1,0,0,0,214,212,1,
		0,0,0,215,219,7,8,0,0,216,218,3,59,29,0,217,216,1,0,0,0,218,221,1,0,0,
		0,219,217,1,0,0,0,219,220,1,0,0,0,220,222,1,0,0,0,221,219,1,0,0,0,222,
		223,7,3,0,0,223,10,1,0,0,0,224,228,7,8,0,0,225,227,3,59,29,0,226,225,1,
		0,0,0,227,230,1,0,0,0,228,226,1,0,0,0,228,229,1,0,0,0,229,231,1,0,0,0,
		230,228,1,0,0,0,231,235,7,6,0,0,232,234,3,59,29,0,233,232,1,0,0,0,234,
		237,1,0,0,0,235,233,1,0,0,0,235,236,1,0,0,0,236,238,1,0,0,0,237,235,1,
		0,0,0,238,242,7,6,0,0,239,241,3,59,29,0,240,239,1,0,0,0,241,244,1,0,0,
		0,242,240,1,0,0,0,242,243,1,0,0,0,243,245,1,0,0,0,244,242,1,0,0,0,245,
		249,7,11,0,0,246,248,3,59,29,0,247,246,1,0,0,0,248,251,1,0,0,0,249,247,
		1,0,0,0,249,250,1,0,0,0,250,252,1,0,0,0,251,249,1,0,0,0,252,256,7,12,0,
		0,253,255,3,59,29,0,254,253,1,0,0,0,255,258,1,0,0,0,256,254,1,0,0,0,256,
		257,1,0,0,0,257,259,1,0,0,0,258,256,1,0,0,0,259,260,7,10,0,0,260,12,1,
		0,0,0,261,265,7,4,0,0,262,264,3,59,29,0,263,262,1,0,0,0,264,267,1,0,0,
		0,265,263,1,0,0,0,265,266,1,0,0,0,266,268,1,0,0,0,267,265,1,0,0,0,268,
		272,7,0,0,0,269,271,3,59,29,0,270,269,1,0,0,0,271,274,1,0,0,0,272,270,
		1,0,0,0,272,273,1,0,0,0,273,275,1,0,0,0,274,272,1,0,0,0,275,279,7,13,0,
		0,276,278,3,59,29,0,277,276,1,0,0,0,278,281,1,0,0,0,279,277,1,0,0,0,279,
		280,1,0,0,0,280,282,1,0,0,0,281,279,1,0,0,0,282,286,7,2,0,0,283,285,3,
		59,29,0,284,283,1,0,0,0,285,288,1,0,0,0,286,284,1,0,0,0,286,287,1,0,0,
		0,287,289,1,0,0,0,288,286,1,0,0,0,289,290,7,10,0,0,290,14,1,0,0,0,291,
		295,7,14,0,0,292,294,3,59,29,0,293,292,1,0,0,0,294,297,1,0,0,0,295,293,
		1,0,0,0,295,296,1,0,0,0,296,298,1,0,0,0,297,295,1,0,0,0,298,302,7,0,0,
		0,299,301,3,59,29,0,300,299,1,0,0,0,301,304,1,0,0,0,302,300,1,0,0,0,302,
		303,1,0,0,0,303,305,1,0,0,0,304,302,1,0,0,0,305,309,7,6,0,0,306,308,3,
		59,29,0,307,306,1,0,0,0,308,311,1,0,0,0,309,307,1,0,0,0,309,310,1,0,0,
		0,310,312,1,0,0,0,311,309,1,0,0,0,312,316,7,4,0,0,313,315,3,59,29,0,314,
		313,1,0,0,0,315,318,1,0,0,0,316,314,1,0,0,0,316,317,1,0,0,0,317,319,1,
		0,0,0,318,316,1,0,0,0,319,323,7,11,0,0,320,322,3,59,29,0,321,320,1,0,0,
		0,322,325,1,0,0,0,323,321,1,0,0,0,323,324,1,0,0,0,324,326,1,0,0,0,325,
		323,1,0,0,0,326,330,7,12,0,0,327,329,3,59,29,0,328,327,1,0,0,0,329,332,
		1,0,0,0,330,328,1,0,0,0,330,331,1,0,0,0,331,333,1,0,0,0,332,330,1,0,0,
		0,333,334,7,2,0,0,334,16,1,0,0,0,335,339,7,0,0,0,336,338,3,59,29,0,337,
		336,1,0,0,0,338,341,1,0,0,0,339,337,1,0,0,0,339,340,1,0,0,0,340,342,1,
		0,0,0,341,339,1,0,0,0,342,343,7,10,0,0,343,18,1,0,0,0,344,348,7,14,0,0,
		345,347,3,59,29,0,346,345,1,0,0,0,347,350,1,0,0,0,348,346,1,0,0,0,348,
		349,1,0,0,0,349,351,1,0,0,0,350,348,1,0,0,0,351,355,7,12,0,0,352,354,3,
		59,29,0,353,352,1,0,0,0,354,357,1,0,0,0,355,353,1,0,0,0,355,356,1,0,0,
		0,356,358,1,0,0,0,357,355,1,0,0,0,358,362,7,8,0,0,359,361,3,59,29,0,360,
		359,1,0,0,0,361,364,1,0,0,0,362,360,1,0,0,0,362,363,1,0,0,0,363,365,1,
		0,0,0,364,362,1,0,0,0,365,369,7,6,0,0,366,368,3,59,29,0,367,366,1,0,0,
		0,368,371,1,0,0,0,369,367,1,0,0,0,369,370,1,0,0,0,370,372,1,0,0,0,371,
		369,1,0,0,0,372,376,7,2,0,0,373,375,3,59,29,0,374,373,1,0,0,0,375,378,
		1,0,0,0,376,374,1,0,0,0,376,377,1,0,0,0,377,379,1,0,0,0,378,376,1,0,0,
		0,379,383,7,1,0,0,380,382,3,59,29,0,381,380,1,0,0,0,382,385,1,0,0,0,383,
		381,1,0,0,0,383,384,1,0,0,0,384,386,1,0,0,0,385,383,1,0,0,0,386,390,7,
		11,0,0,387,389,3,59,29,0,388,387,1,0,0,0,389,392,1,0,0,0,390,388,1,0,0,
		0,390,391,1,0,0,0,391,393,1,0,0,0,392,390,1,0,0,0,393,397,7,12,0,0,394,
		396,3,59,29,0,395,394,1,0,0,0,396,399,1,0,0,0,397,395,1,0,0,0,397,398,
		1,0,0,0,398,400,1,0,0,0,399,397,1,0,0,0,400,401,7,2,0,0,401,20,1,0,0,0,
		402,406,7,11,0,0,403,405,3,59,29,0,404,403,1,0,0,0,405,408,1,0,0,0,406,
		404,1,0,0,0,406,407,1,0,0,0,407,409,1,0,0,0,408,406,1,0,0,0,409,413,7,
		10,0,0,410,412,3,59,29,0,411,410,1,0,0,0,412,415,1,0,0,0,413,411,1,0,0,
		0,413,414,1,0,0,0,414,416,1,0,0,0,415,413,1,0,0,0,416,420,7,0,0,0,417,
		419,3,59,29,0,418,417,1,0,0,0,419,422,1,0,0,0,420,418,1,0,0,0,420,421,
		1,0,0,0,421,423,1,0,0,0,422,420,1,0,0,0,423,427,7,3,0,0,424,426,3,59,29,
		0,425,424,1,0,0,0,426,429,1,0,0,0,427,425,1,0,0,0,427,428,1,0,0,0,428,
		430,1,0,0,0,429,427,1,0,0,0,430,431,7,15,0,0,431,22,1,0,0,0,432,436,7,
		16,0,0,433,435,3,59,29,0,434,433,1,0,0,0,435,438,1,0,0,0,436,434,1,0,0,
		0,436,437,1,0,0,0,437,439,1,0,0,0,438,436,1,0,0,0,439,440,7,17,0,0,440,
		24,1,0,0,0,441,445,7,12,0,0,442,444,3,59,29,0,443,442,1,0,0,0,444,447,
		1,0,0,0,445,443,1,0,0,0,445,446,1,0,0,0,446,448,1,0,0,0,447,445,1,0,0,
		0,448,452,7,2,0,0,449,451,3,59,29,0,450,449,1,0,0,0,451,454,1,0,0,0,452,
		450,1,0,0,0,452,453,1,0,0,0,453,455,1,0,0,0,454,452,1,0,0,0,455,459,7,
		5,0,0,456,458,3,59,29,0,457,456,1,0,0,0,458,461,1,0,0,0,459,457,1,0,0,
		0,459,460,1,0,0,0,460,462,1,0,0,0,461,459,1,0,0,0,462,466,7,2,0,0,463,
		465,3,59,29,0,464,463,1,0,0,0,465,468,1,0,0,0,466,464,1,0,0,0,466,467,
		1,0,0,0,467,469,1,0,0,0,468,466,1,0,0,0,469,473,7,12,0,0,470,472,3,59,
		29,0,471,470,1,0,0,0,472,475,1,0,0,0,473,471,1,0,0,0,473,474,1,0,0,0,474,
		476,1,0,0,0,475,473,1,0,0,0,476,480,7,2,0,0,477,479,3,59,29,0,478,477,
		1,0,0,0,479,482,1,0,0,0,480,478,1,0,0,0,480,481,1,0,0,0,481,483,1,0,0,
		0,482,480,1,0,0,0,483,487,7,3,0,0,484,486,3,59,29,0,485,484,1,0,0,0,486,
		489,1,0,0,0,487,485,1,0,0,0,487,488,1,0,0,0,488,490,1,0,0,0,489,487,1,
		0,0,0,490,494,7,6,0,0,491,493,3,59,29,0,492,491,1,0,0,0,493,496,1,0,0,
		0,494,492,1,0,0,0,494,495,1,0,0,0,495,497,1,0,0,0,496,494,1,0,0,0,497,
		498,7,2,0,0,498,26,1,0,0,0,499,503,7,6,0,0,500,502,3,59,29,0,501,500,1,
		0,0,0,502,505,1,0,0,0,503,501,1,0,0,0,503,504,1,0,0,0,504,506,1,0,0,0,
		505,503,1,0,0,0,506,510,7,8,0,0,507,509,3,59,29,0,508,507,1,0,0,0,509,
		512,1,0,0,0,510,508,1,0,0,0,510,511,1,0,0,0,511,513,1,0,0,0,512,510,1,
		0,0,0,513,517,7,3,0,0,514,516,3,59,29,0,515,514,1,0,0,0,516,519,1,0,0,
		0,517,515,1,0,0,0,517,518,1,0,0,0,518,520,1,0,0,0,519,517,1,0,0,0,520,
		524,7,4,0,0,521,523,3,59,29,0,522,521,1,0,0,0,523,526,1,0,0,0,524,522,
		1,0,0,0,524,525,1,0,0,0,525,527,1,0,0,0,526,524,1,0,0,0,527,531,7,2,0,
		0,528,530,3,59,29,0,529,528,1,0,0,0,530,533,1,0,0,0,531,529,1,0,0,0,531,
		532,1,0,0,0,532,534,1,0,0,0,533,531,1,0,0,0,534,538,7,3,0,0,535,537,3,
		59,29,0,536,535,1,0,0,0,537,540,1,0,0,0,538,536,1,0,0,0,538,539,1,0,0,
		0,539,541,1,0,0,0,540,538,1,0,0,0,541,542,7,4,0,0,542,28,1,0,0,0,543,547,
		7,9,0,0,544,546,3,59,29,0,545,544,1,0,0,0,546,549,1,0,0,0,547,545,1,0,
		0,0,547,548,1,0,0,0,548,550,1,0,0,0,549,547,1,0,0,0,550,554,7,7,0,0,551,
		553,3,59,29,0,552,551,1,0,0,0,553,556,1,0,0,0,554,552,1,0,0,0,554,555,
		1,0,0,0,555,557,1,0,0,0,556,554,1,0,0,0,557,561,7,18,0,0,558,560,3,59,
		29,0,559,558,1,0,0,0,560,563,1,0,0,0,561,559,1,0,0,0,561,562,1,0,0,0,562,
		564,1,0,0,0,563,561,1,0,0,0,564,568,7,11,0,0,565,567,3,59,29,0,566,565,
		1,0,0,0,567,570,1,0,0,0,568,566,1,0,0,0,568,569,1,0,0,0,569,571,1,0,0,
		0,570,568,1,0,0,0,571,572,7,2,0,0,572,30,1,0,0,0,573,577,7,18,0,0,574,
		576,3,59,29,0,575,574,1,0,0,0,576,579,1,0,0,0,577,575,1,0,0,0,577,578,
		1,0,0,0,578,580,1,0,0,0,579,577,1,0,0,0,580,584,7,0,0,0,581,583,3,59,29,
		0,582,581,1,0,0,0,583,586,1,0,0,0,584,582,1,0,0,0,584,585,1,0,0,0,585,
		587,1,0,0,0,586,584,1,0,0,0,587,591,7,19,0,0,588,590,3,59,29,0,589,588,
		1,0,0,0,590,593,1,0,0,0,591,589,1,0,0,0,591,592,1,0,0,0,592,594,1,0,0,
		0,593,591,1,0,0,0,594,595,7,2,0,0,595,32,1,0,0,0,596,600,7,1,0,0,597,599,
		3,59,29,0,598,597,1,0,0,0,599,602,1,0,0,0,600,598,1,0,0,0,600,601,1,0,
		0,0,601,603,1,0,0,0,602,600,1,0,0,0,603,607,7,0,0,0,604,606,3,59,29,0,
		605,604,1,0,0,0,606,609,1,0,0,0,607,605,1,0,0,0,607,608,1,0,0,0,608,610,
		1,0,0,0,609,607,1,0,0,0,610,614,7,10,0,0,611,613,3,59,29,0,612,611,1,0,
		0,0,613,616,1,0,0,0,614,612,1,0,0,0,614,615,1,0,0,0,615,617,1,0,0,0,616,
		614,1,0,0,0,617,621,7,14,0,0,618,620,3,59,29,0,619,618,1,0,0,0,620,623,
		1,0,0,0,621,619,1,0,0,0,621,622,1,0,0,0,622,624,1,0,0,0,623,621,1,0,0,
		0,624,628,7,18,0,0,625,627,3,59,29,0,626,625,1,0,0,0,627,630,1,0,0,0,628,
		626,1,0,0,0,628,629,1,0,0,0,629,631,1,0,0,0,630,628,1,0,0,0,631,635,7,
		7,0,0,632,634,3,59,29,0,633,632,1,0,0,0,634,637,1,0,0,0,635,633,1,0,0,
		0,635,636,1,0,0,0,636,638,1,0,0,0,637,635,1,0,0,0,638,639,7,17,0,0,639,
		34,1,0,0,0,640,644,7,8,0,0,641,643,3,59,29,0,642,641,1,0,0,0,643,646,1,
		0,0,0,644,642,1,0,0,0,644,645,1,0,0,0,645,647,1,0,0,0,646,644,1,0,0,0,
		647,648,7,5,0,0,648,36,1,0,0,0,649,653,7,20,0,0,650,652,3,59,29,0,651,
		650,1,0,0,0,652,655,1,0,0,0,653,651,1,0,0,0,653,654,1,0,0,0,654,656,1,
		0,0,0,655,653,1,0,0,0,656,660,7,0,0,0,657,659,3,59,29,0,658,657,1,0,0,
		0,659,662,1,0,0,0,660,658,1,0,0,0,660,661,1,0,0,0,661,663,1,0,0,0,662,
		660,1,0,0,0,663,667,7,4,0,0,664,666,3,59,29,0,665,664,1,0,0,0,666,669,
		1,0,0,0,667,665,1,0,0,0,667,668,1,0,0,0,668,670,1,0,0,0,669,667,1,0,0,
		0,670,671,7,21,0,0,671,38,1,0,0,0,672,676,7,3,0,0,673,675,3,59,29,0,674,
		673,1,0,0,0,675,678,1,0,0,0,676,674,1,0,0,0,676,677,1,0,0,0,677,679,1,
		0,0,0,678,676,1,0,0,0,679,680,7,8,0,0,680,40,1,0,0,0,681,685,7,7,0,0,682,
		684,3,59,29,0,683,682,1,0,0,0,684,687,1,0,0,0,685,683,1,0,0,0,685,686,
		1,0,0,0,686,688,1,0,0,0,687,685,1,0,0,0,688,692,7,1,0,0,689,691,3,59,29,
		0,690,689,1,0,0,0,691,694,1,0,0,0,692,690,1,0,0,0,692,693,1,0,0,0,693,
		695,1,0,0,0,694,692,1,0,0,0,695,699,7,9,0,0,696,698,3,59,29,0,697,696,
		1,0,0,0,698,701,1,0,0,0,699,697,1,0,0,0,699,700,1,0,0,0,700,702,1,0,0,
		0,701,699,1,0,0,0,702,706,7,7,0,0,703,705,3,59,29,0,704,703,1,0,0,0,705,
		708,1,0,0,0,706,704,1,0,0,0,706,707,1,0,0,0,707,709,1,0,0,0,708,706,1,
		0,0,0,709,713,7,3,0,0,710,712,3,59,29,0,711,710,1,0,0,0,712,715,1,0,0,
		0,713,711,1,0,0,0,713,714,1,0,0,0,714,716,1,0,0,0,715,713,1,0,0,0,716,
		720,7,6,0,0,717,719,3,59,29,0,718,717,1,0,0,0,719,722,1,0,0,0,720,718,
		1,0,0,0,720,721,1,0,0,0,721,723,1,0,0,0,722,720,1,0,0,0,723,727,7,0,0,
		0,724,726,3,59,29,0,725,724,1,0,0,0,726,729,1,0,0,0,727,725,1,0,0,0,727,
		728,1,0,0,0,728,730,1,0,0,0,729,727,1,0,0,0,730,734,7,3,0,0,731,733,3,
		59,29,0,732,731,1,0,0,0,733,736,1,0,0,0,734,732,1,0,0,0,734,735,1,0,0,
		0,735,737,1,0,0,0,736,734,1,0,0,0,737,738,7,15,0,0,738,42,1,0,0,0,739,
		743,7,1,0,0,740,742,3,59,29,0,741,740,1,0,0,0,742,745,1,0,0,0,743,741,
		1,0,0,0,743,744,1,0,0,0,744,746,1,0,0,0,745,743,1,0,0,0,746,750,7,7,0,
		0,747,749,3,59,29,0,748,747,1,0,0,0,749,752,1,0,0,0,750,748,1,0,0,0,750,
		751,1,0,0,0,751,753,1,0,0,0,752,750,1,0,0,0,753,757,7,4,0,0,754,756,3,
		59,29,0,755,754,1,0,0,0,756,759,1,0,0,0,757,755,1,0,0,0,757,758,1,0,0,
		0,758,760,1,0,0,0,759,757,1,0,0,0,760,761,7,7,0,0,761,44,1,0,0,0,762,766,
		7,7,0,0,763,765,3,59,29,0,764,763,1,0,0,0,765,768,1,0,0,0,766,764,1,0,
		0,0,766,767,1,0,0,0,767,769,1,0,0,0,768,766,1,0,0,0,769,773,7,1,0,0,770,
		772,3,59,29,0,771,770,1,0,0,0,772,775,1,0,0,0,773,771,1,0,0,0,773,774,
		1,0,0,0,774,776,1,0,0,0,775,773,1,0,0,0,776,777,7,1,0,0,777,46,1,0,0,0,
		778,782,7,4,0,0,779,781,3,59,29,0,780,779,1,0,0,0,781,784,1,0,0,0,782,
		780,1,0,0,0,782,783,1,0,0,0,783,785,1,0,0,0,784,782,1,0,0,0,785,786,7,
		8,0,0,786,48,1,0,0,0,787,791,7,15,0,0,788,790,3,59,29,0,789,788,1,0,0,
		0,790,793,1,0,0,0,791,789,1,0,0,0,791,792,1,0,0,0,792,794,1,0,0,0,793,
		791,1,0,0,0,794,798,7,0,0,0,795,797,3,59,29,0,796,795,1,0,0,0,797,800,
		1,0,0,0,798,796,1,0,0,0,798,799,1,0,0,0,799,801,1,0,0,0,800,798,1,0,0,
		0,801,805,7,9,0,0,802,804,3,59,29,0,803,802,1,0,0,0,804,807,1,0,0,0,805,
		803,1,0,0,0,805,806,1,0,0,0,806,808,1,0,0,0,807,805,1,0,0,0,808,812,7,
		0,0,0,809,811,3,59,29,0,810,809,1,0,0,0,811,814,1,0,0,0,812,810,1,0,0,
		0,812,813,1,0,0,0,813,815,1,0,0,0,814,812,1,0,0,0,815,819,7,3,0,0,816,
		818,3,59,29,0,817,816,1,0,0,0,818,821,1,0,0,0,819,817,1,0,0,0,819,820,
		1,0,0,0,820,822,1,0,0,0,821,819,1,0,0,0,822,823,7,15,0,0,823,50,1,0,0,
		0,824,828,7,7,0,0,825,827,3,59,29,0,826,825,1,0,0,0,827,830,1,0,0,0,828,
		826,1,0,0,0,828,829,1,0,0,0,829,831,1,0,0,0,830,828,1,0,0,0,831,835,7,
		6,0,0,832,834,3,59,29,0,833,832,1,0,0,0,834,837,1,0,0,0,835,833,1,0,0,
		0,835,836,1,0,0,0,836,838,1,0,0,0,837,835,1,0,0,0,838,842,7,6,0,0,839,
		841,3,59,29,0,840,839,1,0,0,0,841,844,1,0,0,0,842,840,1,0,0,0,842,843,
		1,0,0,0,843,845,1,0,0,0,844,842,1,0,0,0,845,849,7,2,0,0,846,848,3,59,29,
		0,847,846,1,0,0,0,848,851,1,0,0,0,849,847,1,0,0,0,849,850,1,0,0,0,850,
		852,1,0,0,0,851,849,1,0,0,0,852,856,7,14,0,0,853,855,3,59,29,0,854,853,
		1,0,0,0,855,858,1,0,0,0,856,854,1,0,0,0,856,857,1,0,0,0,857,859,1,0,0,
		0,858,856,1,0,0,0,859,860,7,4,0,0,860,52,1,0,0,0,861,865,7,13,0,0,862,
		864,3,59,29,0,863,862,1,0,0,0,864,867,1,0,0,0,865,863,1,0,0,0,865,866,
		1,0,0,0,866,868,1,0,0,0,867,865,1,0,0,0,868,872,7,11,0,0,869,871,3,59,
		29,0,870,869,1,0,0,0,871,874,1,0,0,0,872,870,1,0,0,0,872,873,1,0,0,0,873,
		875,1,0,0,0,874,872,1,0,0,0,875,879,7,18,0,0,876,878,3,59,29,0,877,876,
		1,0,0,0,878,881,1,0,0,0,879,877,1,0,0,0,879,880,1,0,0,0,880,882,1,0,0,
		0,881,879,1,0,0,0,882,886,7,4,0,0,883,885,3,59,29,0,884,883,1,0,0,0,885,
		888,1,0,0,0,886,884,1,0,0,0,886,887,1,0,0,0,887,889,1,0,0,0,888,886,1,
		0,0,0,889,893,7,0,0,0,890,892,3,59,29,0,891,890,1,0,0,0,892,895,1,0,0,
		0,893,891,1,0,0,0,893,894,1,0,0,0,894,896,1,0,0,0,895,893,1,0,0,0,896,
		900,7,14,0,0,897,899,3,59,29,0,898,897,1,0,0,0,899,902,1,0,0,0,900,898,
		1,0,0,0,900,901,1,0,0,0,901,903,1,0,0,0,902,900,1,0,0,0,903,907,7,18,0,
		0,904,906,3,59,29,0,905,904,1,0,0,0,906,909,1,0,0,0,907,905,1,0,0,0,907,
		908,1,0,0,0,908,910,1,0,0,0,909,907,1,0,0,0,910,911,7,17,0,0,911,54,1,
		0,0,0,912,918,3,65,32,0,913,917,3,65,32,0,914,917,3,67,33,0,915,917,5,
		45,0,0,916,913,1,0,0,0,916,914,1,0,0,0,916,915,1,0,0,0,917,920,1,0,0,0,
		918,916,1,0,0,0,918,919,1,0,0,0,919,925,1,0,0,0,920,918,1,0,0,0,921,922,
		5,40,0,0,922,923,3,67,33,0,923,924,5,41,0,0,924,926,1,0,0,0,925,921,1,
		0,0,0,925,926,1,0,0,0,926,56,1,0,0,0,927,929,3,67,33,0,928,927,1,0,0,0,
		929,930,1,0,0,0,930,928,1,0,0,0,930,931,1,0,0,0,931,58,1,0,0,0,932,933,
		7,22,0,0,933,934,1,0,0,0,934,935,6,29,0,0,935,60,1,0,0,0,936,937,5,46,
		0,0,937,62,1,0,0,0,938,940,5,34,0,0,939,941,8,23,0,0,940,939,1,0,0,0,941,
		942,1,0,0,0,942,940,1,0,0,0,942,943,1,0,0,0,943,944,1,0,0,0,944,945,5,
		34,0,0,945,64,1,0,0,0,946,947,7,24,0,0,947,66,1,0,0,0,948,949,7,25,0,0,
		949,68,1,0,0,0,950,951,7,26,0,0,951,70,1,0,0,0,119,0,78,84,91,98,105,112,
		119,126,133,140,147,154,161,168,177,184,191,198,205,212,219,228,235,242,
		249,256,265,272,279,286,295,302,309,316,323,330,339,348,355,362,369,376,
		383,390,397,406,413,420,427,436,445,452,459,466,473,480,487,494,503,510,
		517,524,531,538,547,554,561,568,577,584,591,600,607,614,621,628,635,644,
		653,660,667,676,685,692,699,706,713,720,727,734,743,750,757,766,773,782,
		791,798,805,812,819,828,835,842,849,856,865,872,879,886,893,900,907,916,
		918,925,930,942,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
