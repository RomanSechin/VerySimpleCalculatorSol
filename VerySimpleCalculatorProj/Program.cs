using System.Text.RegularExpressions;
using VerySimpleCalculatorProj;

internal class Program
{
    private static void Main(string[] args)
    {
        string expr = "(2-(3-(4-(3+8))))";
        Regex regexCBraces = new Regex(@"\([^()]*\)");
        var matches = regexCBraces.Matches(expr);
        MathExpression mathExpression = new MathExpression(expr);
        Console.WriteLine(mathExpression.Calculate());
        //foreach ( var item in matches)
        //    Console.WriteLine(item);

    }
}