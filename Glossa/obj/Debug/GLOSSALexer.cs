//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.4.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Sonic\Documents\Visual Studio 2013\Projects\Glossa\Glossa\GLOSSA.g4 by ANTLR 4.4.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Glossa {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.4.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class GLOSSALexer : Lexer {
	public const int
		T__0=1, PROGRAMMA=2, ARXH=3, TELOS_PROGRAMMATOS=4, SYNARTHSH=5, TELOS_SYNARTHSHS=6, 
		DIADIKASIA=7, TELOS_DIADIKASIAS=8, METABLHTES=9, STATHERES=10, AN=11, 
		TOTE=12, TELOS_AN=13, ALLIOS_AN=14, ALLIOS=15, AKERAIES=16, PRAGMATIKES=17, 
		XARAKTHRES=18, LOGIKES=19, GRAPSE=20, EKTIPOSE=21, DIABASE=22, KALESE=23, 
		TRUE=24, FALSE=25, INTEGER=26, DECIMAL=27, STRING=28, IDENTIFIER=29, EQUALS=30, 
		NOTEQUALS=31, GT=32, GE=33, LT=34, LE=35, PLUS=36, MINUS=37, MUL=38, DIV=39, 
		POWER=40, SEMICOLON=41, COMMA=42, ASSIGNMENT=43, LPAREN=44, RPAREN=45, 
		LBRACKET=46, RBRACKET=47, LANCHOR=48, RANCHOR=49, COMMENTS=50, WS=51;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "PROGRAMMA", "ARXH", "TELOS_PROGRAMMATOS", "SYNARTHSH", "TELOS_SYNARTHSHS", 
		"DIADIKASIA", "TELOS_DIADIKASIAS", "METABLHTES", "STATHERES", "AN", "TOTE", 
		"TELOS_AN", "ALLIOS_AN", "ALLIOS", "AKERAIES", "PRAGMATIKES", "XARAKTHRES", 
		"LOGIKES", "GRAPSE", "EKTIPOSE", "DIABASE", "KALESE", "TRUE", "FALSE", 
		"INTEGER", "DECIMAL", "STRING", "IDENTIFIER", "NameChar", "NameStartChar", 
		"EQUALS", "NOTEQUALS", "GT", "GE", "LT", "LE", "PLUS", "MINUS", "MUL", 
		"DIV", "POWER", "SEMICOLON", "COMMA", "ASSIGNMENT", "LPAREN", "RPAREN", 
		"LBRACKET", "RBRACKET", "LANCHOR", "RANCHOR", "COMMENTS", "WS"
	};


	public GLOSSALexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "':'", "'���������'", "'����'", "'�����_������������'", "'���������'", 
		"'�����_����������'", "'����������'", "'�����_�����������'", "'����������'", 
		"'��������'", "'��'", "'����'", "'�����_��'", "'������_��'", "'������'", 
		"'��������'", "'�����������'", "'����������'", "'�������'", "'�����'", 
		"'��������'", "'�������'", "'������'", "'������'", "'������'", null, null, 
		null, null, "'='", "'<>'", "'>'", "'>='", "'<'", "'<='", "'+'", "'-'", 
		"'*'", "'/'", "'^'", "';'", "','", "'<-'", "'('", "')'", "'['", "']'", 
		"'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "PROGRAMMA", "ARXH", "TELOS_PROGRAMMATOS", "SYNARTHSH", "TELOS_SYNARTHSHS", 
		"DIADIKASIA", "TELOS_DIADIKASIAS", "METABLHTES", "STATHERES", "AN", "TOTE", 
		"TELOS_AN", "ALLIOS_AN", "ALLIOS", "AKERAIES", "PRAGMATIKES", "XARAKTHRES", 
		"LOGIKES", "GRAPSE", "EKTIPOSE", "DIABASE", "KALESE", "TRUE", "FALSE", 
		"INTEGER", "DECIMAL", "STRING", "IDENTIFIER", "EQUALS", "NOTEQUALS", "GT", 
		"GE", "LT", "LE", "PLUS", "MINUS", "MUL", "DIV", "POWER", "SEMICOLON", 
		"COMMA", "ASSIGNMENT", "LPAREN", "RPAREN", "LBRACKET", "RBRACKET", "LANCHOR", 
		"RANCHOR", "COMMENTS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "GLOSSA.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x35\x1CA\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3"+
		"\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3"+
		"\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18"+
		"\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19"+
		"\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B"+
		"\x6\x1B\x155\n\x1B\r\x1B\xE\x1B\x156\x3\x1C\x6\x1C\x15A\n\x1C\r\x1C\xE"+
		"\x1C\x15B\x3\x1C\x3\x1C\a\x1C\x160\n\x1C\f\x1C\xE\x1C\x163\v\x1C\x3\x1C"+
		"\a\x1C\x166\n\x1C\f\x1C\xE\x1C\x169\v\x1C\x3\x1C\x3\x1C\x6\x1C\x16D\n"+
		"\x1C\r\x1C\xE\x1C\x16E\x5\x1C\x171\n\x1C\x3\x1D\x3\x1D\a\x1D\x175\n\x1D"+
		"\f\x1D\xE\x1D\x178\v\x1D\x3\x1D\x3\x1D\x3\x1D\a\x1D\x17D\n\x1D\f\x1D\xE"+
		"\x1D\x180\v\x1D\x3\x1D\x5\x1D\x183\n\x1D\x3\x1E\x3\x1E\a\x1E\x187\n\x1E"+
		"\f\x1E\xE\x1E\x18A\v\x1E\x3\x1F\x3\x1F\x5\x1F\x18E\n\x1F\x3 \x3 \x3!\x3"+
		"!\x3\"\x3\"\x3\"\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3&\x3&\x3&\x3\'\x3\'\x3"+
		"(\x3(\x3)\x3)\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3.\x3/\x3/\x3\x30"+
		"\x3\x30\x3\x31\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35"+
		"\x3\x35\a\x35\x1C0\n\x35\f\x35\xE\x35\x1C3\v\x35\x3\x35\x3\x35\x3\x36"+
		"\x3\x36\x3\x36\x3\x36\x2\x2\x2\x37\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v"+
		"\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B"+
		"\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16"+
		"+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39"+
		"\x2\x1E;\x2\x1F=\x2\x2?\x2\x2\x41\x2 \x43\x2!\x45\x2\"G\x2#I\x2$K\x2%"+
		"M\x2&O\x2\'Q\x2(S\x2)U\x2*W\x2+Y\x2,[\x2-]\x2._\x2/\x61\x2\x30\x63\x2"+
		"\x31\x65\x2\x32g\x2\x33i\x2\x34k\x2\x35\x3\x2\t\x3\x2\x32;\x4\x2\f\f)"+
		")\x4\x2\f\f$$\x4\x2\x32;\x61\x61\x10\x2\x43\\\x63|\xB9\xB9\xC2\xD8\xDA"+
		"\xF8\xFA\x37F\x381\x2001\x200E\x200F\x2041\x2042\x2072\x2191\x2C02\x2FF1"+
		"\x3003\xD801\xF902\xFDD1\xFDF2\xFFFF\x4\x2\f\f\xF\xF\x5\x2\v\f\xF\xF\""+
		"\"\x1D3\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)"+
		"\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2"+
		"\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2"+
		"M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2"+
		"\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2"+
		"\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2"+
		"\x2\x2g\x3\x2\x2\x2\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x3m\x3\x2\x2\x2\x5"+
		"o\x3\x2\x2\x2\ay\x3\x2\x2\x2\t~\x3\x2\x2\x2\v\x91\x3\x2\x2\x2\r\x9B\x3"+
		"\x2\x2\x2\xF\xAC\x3\x2\x2\x2\x11\xB7\x3\x2\x2\x2\x13\xC9\x3\x2\x2\x2\x15"+
		"\xD4\x3\x2\x2\x2\x17\xDD\x3\x2\x2\x2\x19\xE0\x3\x2\x2\x2\x1B\xE5\x3\x2"+
		"\x2\x2\x1D\xEE\x3\x2\x2\x2\x1F\xF8\x3\x2\x2\x2!\xFF\x3\x2\x2\x2#\x108"+
		"\x3\x2\x2\x2%\x114\x3\x2\x2\x2\'\x11F\x3\x2\x2\x2)\x127\x3\x2\x2\x2+\x12D"+
		"\x3\x2\x2\x2-\x136\x3\x2\x2\x2/\x13E\x3\x2\x2\x2\x31\x145\x3\x2\x2\x2"+
		"\x33\x14C\x3\x2\x2\x2\x35\x154\x3\x2\x2\x2\x37\x170\x3\x2\x2\x2\x39\x182"+
		"\x3\x2\x2\x2;\x184\x3\x2\x2\x2=\x18D\x3\x2\x2\x2?\x18F\x3\x2\x2\x2\x41"+
		"\x191\x3\x2\x2\x2\x43\x193\x3\x2\x2\x2\x45\x196\x3\x2\x2\x2G\x198\x3\x2"+
		"\x2\x2I\x19B\x3\x2\x2\x2K\x19D\x3\x2\x2\x2M\x1A0\x3\x2\x2\x2O\x1A2\x3"+
		"\x2\x2\x2Q\x1A4\x3\x2\x2\x2S\x1A6\x3\x2\x2\x2U\x1A8\x3\x2\x2\x2W\x1AA"+
		"\x3\x2\x2\x2Y\x1AC\x3\x2\x2\x2[\x1AE\x3\x2\x2\x2]\x1B1\x3\x2\x2\x2_\x1B3"+
		"\x3\x2\x2\x2\x61\x1B5\x3\x2\x2\x2\x63\x1B7\x3\x2\x2\x2\x65\x1B9\x3\x2"+
		"\x2\x2g\x1BB\x3\x2\x2\x2i\x1BD\x3\x2\x2\x2k\x1C6\x3\x2\x2\x2mn\a<\x2\x2"+
		"n\x4\x3\x2\x2\x2op\a\x3A2\x2\x2pq\a\x3A3\x2\x2qr\a\x3A1\x2\x2rs\a\x395"+
		"\x2\x2st\a\x3A3\x2\x2tu\a\x393\x2\x2uv\a\x39E\x2\x2vw\a\x39E\x2\x2wx\a"+
		"\x393\x2\x2x\x6\x3\x2\x2\x2yz\a\x393\x2\x2z{\a\x3A3\x2\x2{|\a\x3A9\x2"+
		"\x2|}\a\x399\x2\x2}\b\x3\x2\x2\x2~\x7F\a\x3A6\x2\x2\x7F\x80\a\x397\x2"+
		"\x2\x80\x81\a\x39D\x2\x2\x81\x82\a\x3A1\x2\x2\x82\x83\a\x3A5\x2\x2\x83"+
		"\x84\a\x61\x2\x2\x84\x85\a\x3A2\x2\x2\x85\x86\a\x3A3\x2\x2\x86\x87\a\x3A1"+
		"\x2\x2\x87\x88\a\x395\x2\x2\x88\x89\a\x3A3\x2\x2\x89\x8A\a\x393\x2\x2"+
		"\x8A\x8B\a\x39E\x2\x2\x8B\x8C\a\x39E\x2\x2\x8C\x8D\a\x393\x2\x2\x8D\x8E"+
		"\a\x3A6\x2\x2\x8E\x8F\a\x3A1\x2\x2\x8F\x90\a\x3A5\x2\x2\x90\n\x3\x2\x2"+
		"\x2\x91\x92\a\x3A5\x2\x2\x92\x93\a\x3A7\x2\x2\x93\x94\a\x39F\x2\x2\x94"+
		"\x95\a\x393\x2\x2\x95\x96\a\x3A3\x2\x2\x96\x97\a\x3A6\x2\x2\x97\x98\a"+
		"\x399\x2\x2\x98\x99\a\x3A5\x2\x2\x99\x9A\a\x399\x2\x2\x9A\f\x3\x2\x2\x2"+
		"\x9B\x9C\a\x3A6\x2\x2\x9C\x9D\a\x397\x2\x2\x9D\x9E\a\x39D\x2\x2\x9E\x9F"+
		"\a\x3A1\x2\x2\x9F\xA0\a\x3A5\x2\x2\xA0\xA1\a\x61\x2\x2\xA1\xA2\a\x3A5"+
		"\x2\x2\xA2\xA3\a\x3A7\x2\x2\xA3\xA4\a\x39F\x2\x2\xA4\xA5\a\x393\x2\x2"+
		"\xA5\xA6\a\x3A3\x2\x2\xA6\xA7\a\x3A6\x2\x2\xA7\xA8\a\x399\x2\x2\xA8\xA9"+
		"\a\x3A5\x2\x2\xA9\xAA\a\x399\x2\x2\xAA\xAB\a\x3A5\x2\x2\xAB\xE\x3\x2\x2"+
		"\x2\xAC\xAD\a\x396\x2\x2\xAD\xAE\a\x39B\x2\x2\xAE\xAF\a\x393\x2\x2\xAF"+
		"\xB0\a\x396\x2\x2\xB0\xB1\a\x39B\x2\x2\xB1\xB2\a\x39C\x2\x2\xB2\xB3\a"+
		"\x393\x2\x2\xB3\xB4\a\x3A5\x2\x2\xB4\xB5\a\x39B\x2\x2\xB5\xB6\a\x393\x2"+
		"\x2\xB6\x10\x3\x2\x2\x2\xB7\xB8\a\x3A6\x2\x2\xB8\xB9\a\x397\x2\x2\xB9"+
		"\xBA\a\x39D\x2\x2\xBA\xBB\a\x3A1\x2\x2\xBB\xBC\a\x3A5\x2\x2\xBC\xBD\a"+
		"\x61\x2\x2\xBD\xBE\a\x396\x2\x2\xBE\xBF\a\x39B\x2\x2\xBF\xC0\a\x393\x2"+
		"\x2\xC0\xC1\a\x396\x2\x2\xC1\xC2\a\x39B\x2\x2\xC2\xC3\a\x39C\x2\x2\xC3"+
		"\xC4\a\x393\x2\x2\xC4\xC5\a\x3A5\x2\x2\xC5\xC6\a\x39B\x2\x2\xC6\xC7\a"+
		"\x393\x2\x2\xC7\xC8\a\x3A5\x2\x2\xC8\x12\x3\x2\x2\x2\xC9\xCA\a\x39E\x2"+
		"\x2\xCA\xCB\a\x397\x2\x2\xCB\xCC\a\x3A6\x2\x2\xCC\xCD\a\x393\x2\x2\xCD"+
		"\xCE\a\x394\x2\x2\xCE\xCF\a\x39D\x2\x2\xCF\xD0\a\x399\x2\x2\xD0\xD1\a"+
		"\x3A6\x2\x2\xD1\xD2\a\x397\x2\x2\xD2\xD3\a\x3A5\x2\x2\xD3\x14\x3\x2\x2"+
		"\x2\xD4\xD5\a\x3A5\x2\x2\xD5\xD6\a\x3A6\x2\x2\xD6\xD7\a\x393\x2\x2\xD7"+
		"\xD8\a\x39A\x2\x2\xD8\xD9\a\x397\x2\x2\xD9\xDA\a\x3A3\x2\x2\xDA\xDB\a"+
		"\x397\x2\x2\xDB\xDC\a\x3A5\x2\x2\xDC\x16\x3\x2\x2\x2\xDD\xDE\a\x393\x2"+
		"\x2\xDE\xDF\a\x39F\x2\x2\xDF\x18\x3\x2\x2\x2\xE0\xE1\a\x3A6\x2\x2\xE1"+
		"\xE2\a\x3A1\x2\x2\xE2\xE3\a\x3A6\x2\x2\xE3\xE4\a\x397\x2\x2\xE4\x1A\x3"+
		"\x2\x2\x2\xE5\xE6\a\x3A6\x2\x2\xE6\xE7\a\x397\x2\x2\xE7\xE8\a\x39D\x2"+
		"\x2\xE8\xE9\a\x3A1\x2\x2\xE9\xEA\a\x3A5\x2\x2\xEA\xEB\a\x61\x2\x2\xEB"+
		"\xEC\a\x393\x2\x2\xEC\xED\a\x39F\x2\x2\xED\x1C\x3\x2\x2\x2\xEE\xEF\a\x393"+
		"\x2\x2\xEF\xF0\a\x39D\x2\x2\xF0\xF1\a\x39D\x2\x2\xF1\xF2\a\x39B\x2\x2"+
		"\xF2\xF3\a\x3AB\x2\x2\xF3\xF4\a\x3A5\x2\x2\xF4\xF5\a\x61\x2\x2\xF5\xF6"+
		"\a\x393\x2\x2\xF6\xF7\a\x39F\x2\x2\xF7\x1E\x3\x2\x2\x2\xF8\xF9\a\x393"+
		"\x2\x2\xF9\xFA\a\x39D\x2\x2\xFA\xFB\a\x39D\x2\x2\xFB\xFC\a\x39B\x2\x2"+
		"\xFC\xFD\a\x3AB\x2\x2\xFD\xFE\a\x3A5\x2\x2\xFE \x3\x2\x2\x2\xFF\x100\a"+
		"\x393\x2\x2\x100\x101\a\x39C\x2\x2\x101\x102\a\x397\x2\x2\x102\x103\a"+
		"\x3A3\x2\x2\x103\x104\a\x393\x2\x2\x104\x105\a\x39B\x2\x2\x105\x106\a"+
		"\x397\x2\x2\x106\x107\a\x3A5\x2\x2\x107\"\x3\x2\x2\x2\x108\x109\a\x3A2"+
		"\x2\x2\x109\x10A\a\x3A3\x2\x2\x10A\x10B\a\x393\x2\x2\x10B\x10C\a\x395"+
		"\x2\x2\x10C\x10D\a\x39E\x2\x2\x10D\x10E\a\x393\x2\x2\x10E\x10F\a\x3A6"+
		"\x2\x2\x10F\x110\a\x39B\x2\x2\x110\x111\a\x39C\x2\x2\x111\x112\a\x397"+
		"\x2\x2\x112\x113\a\x3A5\x2\x2\x113$\x3\x2\x2\x2\x114\x115\a\x3A9\x2\x2"+
		"\x115\x116\a\x393\x2\x2\x116\x117\a\x3A3\x2\x2\x117\x118\a\x393\x2\x2"+
		"\x118\x119\a\x39C\x2\x2\x119\x11A\a\x3A6\x2\x2\x11A\x11B\a\x399\x2\x2"+
		"\x11B\x11C\a\x3A3\x2\x2\x11C\x11D\a\x397\x2\x2\x11D\x11E\a\x3A5\x2\x2"+
		"\x11E&\x3\x2\x2\x2\x11F\x120\a\x39D\x2\x2\x120\x121\a\x3A1\x2\x2\x121"+
		"\x122\a\x395\x2\x2\x122\x123\a\x39B\x2\x2\x123\x124\a\x39C\x2\x2\x124"+
		"\x125\a\x397\x2\x2\x125\x126\a\x3A5\x2\x2\x126(\x3\x2\x2\x2\x127\x128"+
		"\a\x395\x2\x2\x128\x129\a\x3A3\x2\x2\x129\x12A\a\x393\x2\x2\x12A\x12B"+
		"\a\x3AA\x2\x2\x12B\x12C\a\x397\x2\x2\x12C*\x3\x2\x2\x2\x12D\x12E\a\x397"+
		"\x2\x2\x12E\x12F\a\x39C\x2\x2\x12F\x130\a\x3A6\x2\x2\x130\x131\a\x3A7"+
		"\x2\x2\x131\x132\a\x3A2\x2\x2\x132\x133\a\x3AB\x2\x2\x133\x134\a\x3A5"+
		"\x2\x2\x134\x135\a\x397\x2\x2\x135,\x3\x2\x2\x2\x136\x137\a\x396\x2\x2"+
		"\x137\x138\a\x39B\x2\x2\x138\x139\a\x393\x2\x2\x139\x13A\a\x394\x2\x2"+
		"\x13A\x13B\a\x393\x2\x2\x13B\x13C\a\x3A5\x2\x2\x13C\x13D\a\x397\x2\x2"+
		"\x13D.\x3\x2\x2\x2\x13E\x13F\a\x39C\x2\x2\x13F\x140\a\x393\x2\x2\x140"+
		"\x141\a\x39D\x2\x2\x141\x142\a\x397\x2\x2\x142\x143\a\x3A5\x2\x2\x143"+
		"\x144\a\x397\x2\x2\x144\x30\x3\x2\x2\x2\x145\x146\a\x393\x2\x2\x146\x147"+
		"\a\x39D\x2\x2\x147\x148\a\x399\x2\x2\x148\x149\a\x39A\x2\x2\x149\x14A"+
		"\a\x399\x2\x2\x14A\x14B\a\x3A5\x2\x2\x14B\x32\x3\x2\x2\x2\x14C\x14D\a"+
		"\x3AA\x2\x2\x14D\x14E\a\x397\x2\x2\x14E\x14F\a\x3A7\x2\x2\x14F\x150\a"+
		"\x396\x2\x2\x150\x151\a\x399\x2\x2\x151\x152\a\x3A5\x2\x2\x152\x34\x3"+
		"\x2\x2\x2\x153\x155\t\x2\x2\x2\x154\x153\x3\x2\x2\x2\x155\x156\x3\x2\x2"+
		"\x2\x156\x154\x3\x2\x2\x2\x156\x157\x3\x2\x2\x2\x157\x36\x3\x2\x2\x2\x158"+
		"\x15A\t\x2\x2\x2\x159\x158\x3\x2\x2\x2\x15A\x15B\x3\x2\x2\x2\x15B\x159"+
		"\x3\x2\x2\x2\x15B\x15C\x3\x2\x2\x2\x15C\x15D\x3\x2\x2\x2\x15D\x161\a\x30"+
		"\x2\x2\x15E\x160\t\x2\x2\x2\x15F\x15E\x3\x2\x2\x2\x160\x163\x3\x2\x2\x2"+
		"\x161\x15F\x3\x2\x2\x2\x161\x162\x3\x2\x2\x2\x162\x171\x3\x2\x2\x2\x163"+
		"\x161\x3\x2\x2\x2\x164\x166\t\x2\x2\x2\x165\x164\x3\x2\x2\x2\x166\x169"+
		"\x3\x2\x2\x2\x167\x165\x3\x2\x2\x2\x167\x168\x3\x2\x2\x2\x168\x16A\x3"+
		"\x2\x2\x2\x169\x167\x3\x2\x2\x2\x16A\x16C\a\x30\x2\x2\x16B\x16D\t\x2\x2"+
		"\x2\x16C\x16B\x3\x2\x2\x2\x16D\x16E\x3\x2\x2\x2\x16E\x16C\x3\x2\x2\x2"+
		"\x16E\x16F\x3\x2\x2\x2\x16F\x171\x3\x2\x2\x2\x170\x159\x3\x2\x2\x2\x170"+
		"\x167\x3\x2\x2\x2\x171\x38\x3\x2\x2\x2\x172\x176\a)\x2\x2\x173\x175\n"+
		"\x3\x2\x2\x174\x173\x3\x2\x2\x2\x175\x178\x3\x2\x2\x2\x176\x174\x3\x2"+
		"\x2\x2\x176\x177\x3\x2\x2\x2\x177\x179\x3\x2\x2\x2\x178\x176\x3\x2\x2"+
		"\x2\x179\x183\a)\x2\x2\x17A\x17E\a$\x2\x2\x17B\x17D\n\x4\x2\x2\x17C\x17B"+
		"\x3\x2\x2\x2\x17D\x180\x3\x2\x2\x2\x17E\x17C\x3\x2\x2\x2\x17E\x17F\x3"+
		"\x2\x2\x2\x17F\x181\x3\x2\x2\x2\x180\x17E\x3\x2\x2\x2\x181\x183\a$\x2"+
		"\x2\x182\x172\x3\x2\x2\x2\x182\x17A\x3\x2\x2\x2\x183:\x3\x2\x2\x2\x184"+
		"\x188\x5? \x2\x185\x187\x5=\x1F\x2\x186\x185\x3\x2\x2\x2\x187\x18A\x3"+
		"\x2\x2\x2\x188\x186\x3\x2\x2\x2\x188\x189\x3\x2\x2\x2\x189<\x3\x2\x2\x2"+
		"\x18A\x188\x3\x2\x2\x2\x18B\x18E\x5? \x2\x18C\x18E\t\x5\x2\x2\x18D\x18B"+
		"\x3\x2\x2\x2\x18D\x18C\x3\x2\x2\x2\x18E>\x3\x2\x2\x2\x18F\x190\t\x6\x2"+
		"\x2\x190@\x3\x2\x2\x2\x191\x192\a?\x2\x2\x192\x42\x3\x2\x2\x2\x193\x194"+
		"\a>\x2\x2\x194\x195\a@\x2\x2\x195\x44\x3\x2\x2\x2\x196\x197\a@\x2\x2\x197"+
		"\x46\x3\x2\x2\x2\x198\x199\a@\x2\x2\x199\x19A\a?\x2\x2\x19AH\x3\x2\x2"+
		"\x2\x19B\x19C\a>\x2\x2\x19CJ\x3\x2\x2\x2\x19D\x19E\a>\x2\x2\x19E\x19F"+
		"\a?\x2\x2\x19FL\x3\x2\x2\x2\x1A0\x1A1\a-\x2\x2\x1A1N\x3\x2\x2\x2\x1A2"+
		"\x1A3\a/\x2\x2\x1A3P\x3\x2\x2\x2\x1A4\x1A5\a,\x2\x2\x1A5R\x3\x2\x2\x2"+
		"\x1A6\x1A7\a\x31\x2\x2\x1A7T\x3\x2\x2\x2\x1A8\x1A9\a`\x2\x2\x1A9V\x3\x2"+
		"\x2\x2\x1AA\x1AB\a=\x2\x2\x1ABX\x3\x2\x2\x2\x1AC\x1AD\a.\x2\x2\x1ADZ\x3"+
		"\x2\x2\x2\x1AE\x1AF\a>\x2\x2\x1AF\x1B0\a/\x2\x2\x1B0\\\x3\x2\x2\x2\x1B1"+
		"\x1B2\a*\x2\x2\x1B2^\x3\x2\x2\x2\x1B3\x1B4\a+\x2\x2\x1B4`\x3\x2\x2\x2"+
		"\x1B5\x1B6\a]\x2\x2\x1B6\x62\x3\x2\x2\x2\x1B7\x1B8\a_\x2\x2\x1B8\x64\x3"+
		"\x2\x2\x2\x1B9\x1BA\a}\x2\x2\x1BA\x66\x3\x2\x2\x2\x1BB\x1BC\a\x7F\x2\x2"+
		"\x1BCh\x3\x2\x2\x2\x1BD\x1C1\a#\x2\x2\x1BE\x1C0\n\a\x2\x2\x1BF\x1BE\x3"+
		"\x2\x2\x2\x1C0\x1C3\x3\x2\x2\x2\x1C1\x1BF\x3\x2\x2\x2\x1C1\x1C2\x3\x2"+
		"\x2\x2\x1C2\x1C4\x3\x2\x2\x2\x1C3\x1C1\x3\x2\x2\x2\x1C4\x1C5\b\x35\x2"+
		"\x2\x1C5j\x3\x2\x2\x2\x1C6\x1C7\t\b\x2\x2\x1C7\x1C8\x3\x2\x2\x2\x1C8\x1C9"+
		"\b\x36\x2\x2\x1C9l\x3\x2\x2\x2\xF\x2\x156\x15B\x161\x167\x16E\x170\x176"+
		"\x17E\x182\x188\x18D\x1C1\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Glossa