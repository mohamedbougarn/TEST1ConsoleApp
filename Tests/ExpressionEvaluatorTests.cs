using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ExpressionEvaluatorTests
{
    private ExpressionEvaluator _evaluator;

    [TestInitialize]
    public void Setup()
    {
        var operators = new List<IOperator>
        {
            new AddOperator(),
            new SubtractOperator(),
            new MultiplyOperator()
        };
        _evaluator = new ExpressionEvaluator(operators);
    }

    [TestMethod]
    public void TestAddition()
    {
        Assert.AreEqual(3, _evaluator.Evaluate("1 + 2"));
    }

    [TestMethod]
    public void TestMultiplication()
    {
        Assert.AreEqual(12, _evaluator.Evaluate("3 * 4"));
    }

    [TestMethod]
    public void TestSubtraction()
    {
        Assert.AreEqual(9, _evaluator.Evaluate("11 - 2"));
    }

    [TestMethod]
    public void TestComplexExpression1()
    {
        Assert.AreEqual(5, _evaluator.Evaluate("2 * 3 - 1"));
    }

    [TestMethod]
    public void TestComplexExpression2()
    {
        Assert.AreEqual(-4, _evaluator.Evaluate("6 - 2 * 5"));
    }
}