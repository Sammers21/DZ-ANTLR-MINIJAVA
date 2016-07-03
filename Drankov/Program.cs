using System;
using System.Text;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace GOGOCSHARP
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            for (i = 1; i < 8; i++)
            {
                try {
                    string input = File.ReadAllText("test" + i + ".minijava");
                    var ms = new MemoryStream(Encoding.UTF8.GetBytes(input));
                    var lexer = new MiniJavaGramLexer(new AntlrInputStream(ms));
                    var tokens = new CommonTokenStream(lexer);

                    //  tokens.Fill();

                    /*  foreach(var tok in tokens.GetTokens())
                      {
                          Console.WriteLine(tok);
                      }*/
                    var parser = new MiniJavaGramParser(tokens);
                    var tree = parser.prog();
                    var pastwk = new ParseTreeWalker();
                    pastwk.Walk(new LISTENERMINIJAVA(), tree);
                
                }
                catch
                {
                    Console.WriteLine("ошибки в test" + i + ".minijava");
                }
            }
        }
    }
}
