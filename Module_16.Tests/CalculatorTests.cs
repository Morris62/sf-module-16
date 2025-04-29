namespace Module_16.Tests;

[TestFixture]
public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MultiplicationMustReturnNotNullValue()
    {
        var calc = new Calculator();
        Assert.That(calc.Multiply(4, 2), Is.EqualTo(8), "Значения должны быть равны");
    }

    [Test]
    public void SubtractionMustReturnCorrectValue()
    {
        var calc = new Calculator();
        Assert.That(calc.Subtract(10, 9), Is.EqualTo(1), "Значения должны быть равны");
    }

    [Test]
    public void DivisionMustReturnCorrectValue()
    {
        var calc = new Calculator();
        Assert.That(calc.Divide(10, 5), Is.EqualTo(2), "Значения должны быть равны");
    }

    [Test]
    public void DivisionMustReturnException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }

    [Test]
    public void AdditionMustReturnCorrectValue()
    {
        var calc = new Calculator();
        Assert.That(calc.Add(1, 2), Is.EqualTo(3), "Значения должны быть равны");
    }

    [Test]
    public void OperationsMustReturnOverflowException()
    {
        var calc = new Calculator();
        Assert.Throws<OverflowException>(() => calc.Add(int.MaxValue, 1));
        Assert.Throws<OverflowException>(() => calc.Multiply(int.MaxValue, int.MinValue));
        Assert.Throws<OverflowException>(() => calc.Subtract(int.MinValue, int.MaxValue));
    }
}