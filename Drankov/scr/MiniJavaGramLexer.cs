//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MiniJavaGram.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class MiniJavaGramLexer : Lexer {
	public const int
		T__0=1, T__1=2, RETURN=3, CLASS=4, STATIC=5, DOUBLE=6, STRING=7, VOID=8, 
		ENUM=9, PUBLIC=10, FOR=11, DOUBLE_QUOTE=12, ARRAYSQARES=13, COMMETSLASH=14, 
		SYSTEMOUTPRINTLN=15, MULT=16, ASSIGN=17, OBRACE=18, CBRACE=19, DT=20, 
		DC=21, COMMA=22, DOT=23, LBRACKET=24, RBRACKET=25, PASS=26, DIGIT=27, 
		ID=28, WS=29;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "RETURN", "CLASS", "STATIC", "DOUBLE", "STRING", "VOID", 
		"ENUM", "PUBLIC", "FOR", "DOUBLE_QUOTE", "ARRAYSQARES", "COMMETSLASH", 
		"SYSTEMOUTPRINTLN", "MULT", "ASSIGN", "OBRACE", "CBRACE", "DT", "DC", 
		"COMMA", "DOT", "LBRACKET", "RBRACKET", "PASS", "DIGIT", "ID", "WS"
	};


	public MiniJavaGramLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'main'", "' args'", "'return'", "'class'", "'static'", "'double'", 
		"'String'", "'void'", "'enum'", "'public'", "'for'", "'\"'", "'[]'", "'//'", 
		"'System.out.println'", "'*'", "'='", "'{'", "'}'", "':'", "';'", "','", 
		"'.'", "'('", "')'", "' '"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "RETURN", "CLASS", "STATIC", "DOUBLE", "STRING", "VOID", 
		"ENUM", "PUBLIC", "FOR", "DOUBLE_QUOTE", "ARRAYSQARES", "COMMETSLASH", 
		"SYSTEMOUTPRINTLN", "MULT", "ASSIGN", "OBRACE", "CBRACE", "DT", "DC", 
		"COMMA", "DOT", "LBRACKET", "RBRACKET", "PASS", "DIGIT", "ID", "WS"
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

	public override string GrammarFileName { get { return "MiniJavaGram.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x1F");
		sb.Append("\xC3\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6");
		sb.Append("\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f");
		sb.Append("\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4");
		sb.Append("\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16");
		sb.Append("\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B");
		sb.Append("\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3");
		sb.Append("\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3");
		sb.Append("\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3");
		sb.Append("\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3");
		sb.Append("\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3");
		sb.Append("\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3");
		sb.Append("\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10");
		sb.Append("\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3");
		sb.Append("\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11");
		sb.Append("\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3");
		sb.Append("\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A");
		sb.Append("\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x6\x1C\xB2\n\x1C\r\x1C\xE\x1C\xB3");
		sb.Append("\x3\x1D\x3\x1D\a\x1D\xB8\n\x1D\f\x1D\xE\x1D\xBB\v\x1D\x3\x1E");
		sb.Append("\x6\x1E\xBE\n\x1E\r\x1E\xE\x1E\xBF\x3\x1E\x3\x1E\x2\x2\x1F\x3");
		sb.Append("\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19");
		sb.Append("\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18");
		sb.Append("/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F\x3\x2\x6");
		sb.Append("\x3\x2\x32;\x4\x2\x43\\\x63|\x5\x2\x32;\x43\\\x63|\x5\x2\v\f");
		sb.Append("\xF\xF\"\"\xC5\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2");
		sb.Append("\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2");
		sb.Append("\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15");
		sb.Append("\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3");
		sb.Append("\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2");
		sb.Append("\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3");
		sb.Append("\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2");
		sb.Append("\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37");
		sb.Append("\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x3=\x3\x2\x2");
		sb.Append("\x2\x5\x42\x3\x2\x2\x2\aH\x3\x2\x2\x2\tO\x3\x2\x2\x2\vU\x3\x2");
		sb.Append("\x2\x2\r\\\x3\x2\x2\x2\xF\x63\x3\x2\x2\x2\x11j\x3\x2\x2\x2\x13");
		sb.Append("o\x3\x2\x2\x2\x15t\x3\x2\x2\x2\x17{\x3\x2\x2\x2\x19\x7F\x3\x2");
		sb.Append("\x2\x2\x1B\x81\x3\x2\x2\x2\x1D\x84\x3\x2\x2\x2\x1F\x87\x3\x2");
		sb.Append("\x2\x2!\x9A\x3\x2\x2\x2#\x9C\x3\x2\x2\x2%\x9E\x3\x2\x2\x2\'");
		sb.Append("\xA0\x3\x2\x2\x2)\xA2\x3\x2\x2\x2+\xA4\x3\x2\x2\x2-\xA6\x3\x2");
		sb.Append("\x2\x2/\xA8\x3\x2\x2\x2\x31\xAA\x3\x2\x2\x2\x33\xAC\x3\x2\x2");
		sb.Append("\x2\x35\xAE\x3\x2\x2\x2\x37\xB1\x3\x2\x2\x2\x39\xB5\x3\x2\x2");
		sb.Append("\x2;\xBD\x3\x2\x2\x2=>\ao\x2\x2>?\a\x63\x2\x2?@\ak\x2\x2@\x41");
		sb.Append("\ap\x2\x2\x41\x4\x3\x2\x2\x2\x42\x43\a\"\x2\x2\x43\x44\a\x63");
		sb.Append("\x2\x2\x44\x45\at\x2\x2\x45\x46\ai\x2\x2\x46G\au\x2\x2G\x6\x3");
		sb.Append("\x2\x2\x2HI\at\x2\x2IJ\ag\x2\x2JK\av\x2\x2KL\aw\x2\x2LM\at\x2");
		sb.Append("\x2MN\ap\x2\x2N\b\x3\x2\x2\x2OP\a\x65\x2\x2PQ\an\x2\x2QR\a\x63");
		sb.Append("\x2\x2RS\au\x2\x2ST\au\x2\x2T\n\x3\x2\x2\x2UV\au\x2\x2VW\av");
		sb.Append("\x2\x2WX\a\x63\x2\x2XY\av\x2\x2YZ\ak\x2\x2Z[\a\x65\x2\x2[\f");
		sb.Append("\x3\x2\x2\x2\\]\a\x66\x2\x2]^\aq\x2\x2^_\aw\x2\x2_`\a\x64\x2");
		sb.Append("\x2`\x61\an\x2\x2\x61\x62\ag\x2\x2\x62\xE\x3\x2\x2\x2\x63\x64");
		sb.Append("\aU\x2\x2\x64\x65\av\x2\x2\x65\x66\at\x2\x2\x66g\ak\x2\x2gh");
		sb.Append("\ap\x2\x2hi\ai\x2\x2i\x10\x3\x2\x2\x2jk\ax\x2\x2kl\aq\x2\x2");
		sb.Append("lm\ak\x2\x2mn\a\x66\x2\x2n\x12\x3\x2\x2\x2op\ag\x2\x2pq\ap\x2");
		sb.Append("\x2qr\aw\x2\x2rs\ao\x2\x2s\x14\x3\x2\x2\x2tu\ar\x2\x2uv\aw\x2");
		sb.Append("\x2vw\a\x64\x2\x2wx\an\x2\x2xy\ak\x2\x2yz\a\x65\x2\x2z\x16\x3");
		sb.Append("\x2\x2\x2{|\ah\x2\x2|}\aq\x2\x2}~\at\x2\x2~\x18\x3\x2\x2\x2");
		sb.Append("\x7F\x80\a$\x2\x2\x80\x1A\x3\x2\x2\x2\x81\x82\a]\x2\x2\x82\x83");
		sb.Append("\a_\x2\x2\x83\x1C\x3\x2\x2\x2\x84\x85\a\x31\x2\x2\x85\x86\a");
		sb.Append("\x31\x2\x2\x86\x1E\x3\x2\x2\x2\x87\x88\aU\x2\x2\x88\x89\a{\x2");
		sb.Append("\x2\x89\x8A\au\x2\x2\x8A\x8B\av\x2\x2\x8B\x8C\ag\x2\x2\x8C\x8D");
		sb.Append("\ao\x2\x2\x8D\x8E\a\x30\x2\x2\x8E\x8F\aq\x2\x2\x8F\x90\aw\x2");
		sb.Append("\x2\x90\x91\av\x2\x2\x91\x92\a\x30\x2\x2\x92\x93\ar\x2\x2\x93");
		sb.Append("\x94\at\x2\x2\x94\x95\ak\x2\x2\x95\x96\ap\x2\x2\x96\x97\av\x2");
		sb.Append("\x2\x97\x98\an\x2\x2\x98\x99\ap\x2\x2\x99 \x3\x2\x2\x2\x9A\x9B");
		sb.Append("\a,\x2\x2\x9B\"\x3\x2\x2\x2\x9C\x9D\a?\x2\x2\x9D$\x3\x2\x2\x2");
		sb.Append("\x9E\x9F\a}\x2\x2\x9F&\x3\x2\x2\x2\xA0\xA1\a\x7F\x2\x2\xA1(");
		sb.Append("\x3\x2\x2\x2\xA2\xA3\a<\x2\x2\xA3*\x3\x2\x2\x2\xA4\xA5\a=\x2");
		sb.Append("\x2\xA5,\x3\x2\x2\x2\xA6\xA7\a.\x2\x2\xA7.\x3\x2\x2\x2\xA8\xA9");
		sb.Append("\a\x30\x2\x2\xA9\x30\x3\x2\x2\x2\xAA\xAB\a*\x2\x2\xAB\x32\x3");
		sb.Append("\x2\x2\x2\xAC\xAD\a+\x2\x2\xAD\x34\x3\x2\x2\x2\xAE\xAF\a\"\x2");
		sb.Append("\x2\xAF\x36\x3\x2\x2\x2\xB0\xB2\t\x2\x2\x2\xB1\xB0\x3\x2\x2");
		sb.Append("\x2\xB2\xB3\x3\x2\x2\x2\xB3\xB1\x3\x2\x2\x2\xB3\xB4\x3\x2\x2");
		sb.Append("\x2\xB4\x38\x3\x2\x2\x2\xB5\xB9\t\x3\x2\x2\xB6\xB8\t\x4\x2\x2");
		sb.Append("\xB7\xB6\x3\x2\x2\x2\xB8\xBB\x3\x2\x2\x2\xB9\xB7\x3\x2\x2\x2");
		sb.Append("\xB9\xBA\x3\x2\x2\x2\xBA:\x3\x2\x2\x2\xBB\xB9\x3\x2\x2\x2\xBC");
		sb.Append("\xBE\t\x5\x2\x2\xBD\xBC\x3\x2\x2\x2\xBE\xBF\x3\x2\x2\x2\xBF");
		sb.Append("\xBD\x3\x2\x2\x2\xBF\xC0\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC1");
		sb.Append("\xC2\b\x1E\x2\x2\xC2<\x3\x2\x2\x2\x6\x2\xB3\xB9\xBF\x3\b\x2");
		sb.Append("\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
