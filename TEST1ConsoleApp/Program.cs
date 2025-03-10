using TEST1ConsoleApp.interfaces;
using TEST1ConsoleApp.models;

class Program
{
    static void Main(string[] args)
    {
         IList<IOperator> operators = new List<IOperator>
        {
            new AddOperator(),
            new SubtractOperator(),
            new MultiplyOperator()
        };

        var evaluator = new ExpressionEvaluator(operators);

        Console.WriteLine("Enter an expression (e.g., '1 + 2' or '6 - 2 * 5'):");
        var expression = Console.ReadLine();

        try
        {
            var result = evaluator.Evaluate(expression);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}