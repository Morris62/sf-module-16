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
        Assert.That(calc.Subtraction(10, 9), Is.EqualTo(1), "Значения должны быть равны");
    }

    [Test]
    public void DivisionMustReturnCorrectValue()
    {
        var calc = new Calculator();
        Assert.That(calc.Division(10, 5), Is.EqualTo(2), "Значения должны быть равны");
    }

    [Test]
    public void DivisionMustReturnException()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Division(10, 0));
    }
}