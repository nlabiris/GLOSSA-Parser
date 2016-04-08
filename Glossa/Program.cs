using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Glossa {
    public class Program {
        public static void Main(string[] args) {
            StreamReader stream = new StreamReader(args[0]);
            AntlrInputStream antlr = new AntlrInputStream(stream.ReadToEnd());
            GLOSSALexer lexer = new GLOSSALexer(antlr);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            GLOSSAParser parser = new GLOSSAParser(tokens);
            IParseTree tree = parser.file();

            ParseTreeWalker walker = new ParseTreeWalker();
            GLOSSAParseTreePrinter parseTreePrinter = new GLOSSAParseTreePrinter("parsetree.dot");
            walker.Walk(parseTreePrinter, tree);

            parseTreePrinter.CallGraphViz("parsetree.dot", "parsetree.png");

            IList<IToken> tokensList = tokens.GetTokens();
            foreach (IToken token in tokensList) {
                Console.WriteLine(token);
            }
        }
    }
}