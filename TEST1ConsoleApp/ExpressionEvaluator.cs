using TEST1ConsoleApp.interfaces;

public class ExpressionEvaluator
{
    private readonly IList<IOperator> _operators;

    public ExpressionEvaluator(IList<IOperator> operators)
    {
        _operators = operators;
    }

    public int Evaluate(string? expression)
    {
        if (expression == null)
        throw new ArgumentNullException(nameof(expression), "Expression cannot be null");

        var tokens = expression.Split(' ');
        var numbers = new Stack<int>();
        var operators = new Stack<IOperator>();

        for (int i = 0; i < tokens.Length; i++)
        {
            var token = tokens[i];

            if (int.TryParse(token, out int number))
            {
                numbers.Push(number);
            }
            else
            {
                var currentOperator = _operators.FirstOrDefault(op => op.Symbol == token);
                if (currentOperator == null)
                    throw new ArgumentException($"Unknown operator: {token}");

                while (operators.Count > 0 && operators.Peek().Priority >= currentOperator.Priority)
                {
                    var op = operators.Pop();
                    var right = numbers.Pop();
                    var left = numbers.Pop();
                    numbers.Push(op.Execute(left, right));
                }

                operators.Push(currentOperator);
            }
        }

        while (operators.Count > 0)
        {
            var op = operators.Pop();
            var right = numbers.Pop();
            var left = numbers.Pop();
            numbers.Push(op.Execute(left, right));
        }

        return numbers.Pop();
    }
}