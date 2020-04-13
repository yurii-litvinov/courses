using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;

namespace AntlrExample
{
    class CalculatorVisitor: ExampleBaseVisitor<int>
    {
        public override int VisitBinOpExpr([NotNull] ExampleParser.BinOpExprContext context)
        {
            var leftPart = context.expression(0).Accept(this);
            var rightPart = context.expression(1).Accept(this);
            return context.GetChild(1).GetText() switch
            {
                "+" => leftPart + rightPart,
                "-" => leftPart - rightPart,
                _ => throw new InvalidOperationException()
            };
        }

        public override int VisitNumberExpr([NotNull] ExampleParser.NumberExprContext context)
            => int.Parse(context.GetText());
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = "1 + 3 - 1";

            var inputStream = new AntlrInputStream(text);
            var lexer = new ExampleLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new ExampleParser(commonTokenStream);

            var context = parser.expression();

            var visitor = new CalculatorVisitor();
            var result = context.Accept(visitor);
            Console.WriteLine($"result = {result}");
        }
    }
}
