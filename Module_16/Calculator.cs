namespace Module_16;

public class Calculator
{
    public int Multiply(int a, int b)
    {
        checked
        {
            return a * b;
        }
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Subtract(int a, int b)
    {
        checked
        {
            return a - b;
        }
    }

    public int Add(int a, int b)
    {
        checked
        {
            return a + b;
        }
    }
}