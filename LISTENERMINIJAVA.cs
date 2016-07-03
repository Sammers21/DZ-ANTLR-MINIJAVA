using Antlr4.Runtime.Misc;
using System;
using System.IO;
using System.Text;

namespace GOGOCSHARP
{
    class LISTENERMINIJAVA : MiniJavaGramBaseListener
    {
        string res = "using System;\n";

        public override void EnterProg([NotNull] MiniJavaGramParser.ProgContext context)
        {


            res += "class " + context.ID().GetText() + " {\n";

        }

        public override void ExitProg([NotNull] MiniJavaGramParser.ProgContext context)
        {

            res += "\n}";
           // Console.WriteLine(res + "\n\n\n");
            File.WriteAllText("test" + Program.i.ToString() + ".cs", res, Encoding.UTF8);

        }

        public override void EnterEnumdeclar([NotNull] MiniJavaGramParser.EnumdeclarContext context)
        {
            res += "enum " + context.ID()[0].GetText() + "{\n";
            if (context.ID().Length > 1)
            {
                for (int i = 1; i < context.ID().Length; i++)
                {
                    if (i==context.ID().Length-1)
                    {
                        res += context.ID()[i].GetText();
                        continue;
                    }
                    res += context.ID()[i].GetText()+",";

                }
            }

        }

        public override void ExitEnumdeclar([NotNull] MiniJavaGramParser.EnumdeclarContext context)
        {
            res += "\n};\n";

        }

        public override void EnterMain([NotNull] MiniJavaGramParser.MainContext context)
        {
            res += "public static void Main(string[] args){\n";
        }

        public override void ExitMain([NotNull] MiniJavaGramParser.MainContext context)
        {
            res += "\n}";
        }

        bool FORFLAG = false;

        public override void ExitExprassion([NotNull] MiniJavaGramParser.ExprassionContext context)
        {
            if (context.children[0].GetText() == "for" && FORFLAG == true)
            {
                FORFLAG = false;
                res += "\n}\n";
            }
        }

        public override void EnterExprassion([NotNull] MiniJavaGramParser.ExprassionContext context)
        {
            if (context.children[0].GetText() == "return")
            {
                for (int i = 0; i < context.children.Count; i++)
                {
                    res += context.children[i].GetText();

                }
                res += "\n";
                return;
            }

            if (context.children[0].GetText() == "System.out.println")
            {
                res += "Console.WriteLine";
                for (int i = 1; i < context.children.Count; i++)
                {
                    res += context.children[i].GetText();

                }
                res += "\n";
                return;
            }
            if (context.children[0].GetText() == "for")
            {
                res += "foreach";
                for (int i = 1; i < context.children.Count; i++)
                {
                    if (context.children[i].GetText() == ":")
                    {
                        res += " in";
                        continue;
                    }
                    if (context.children[i].GetText() == "{")
                    {
                        res += "{\n";
                        FORFLAG = true;
                        break;
                    }
                    res += context.children[i].GetText();
                }

                return;
            }
            if (context.children[0].GetText().Contains("double"))
            {
                for (int i = 0; i < context.children.Count; i++)
                {
                    res += context.children[i].GetText();

                }
                res += "\n";
                return;
            }
            else
            {
                for (int i = 0; i < context.children.Count; i++)
                {
                    res += context.children[i].GetText();

                }
                res += "\n";
                return;
            }



        }

        public override void EnterOtherMthod([NotNull] MiniJavaGramParser.OtherMthodContext context)
        {
            res += "public static " + context.children[4].GetText() + " " + context.ID().GetText() + "(" + context.args().GetText() + "){\n";
        }

        public override void ExitOtherMthod([NotNull] MiniJavaGramParser.OtherMthodContext context)
        {
            res += "\n}\n";
        }

    }


}
