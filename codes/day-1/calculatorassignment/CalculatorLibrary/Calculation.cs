namespace CalculatorLibrary;

public class Calculation
{
    public int Add(int firstNumber, int secondNumber)
    {
        return (firstNumber + secondNumber);
    }
    public int Subtract(int firstNumber, int secondNumber)
    {
        return (firstNumber - secondNumber);
    }
    public int Multiply(int firstNumber, int secondNumber)
    {
        return (firstNumber * secondNumber);
    }
    public int Divide(int firstNumber, int secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new System.DivideByZeroException("denominator should not be zero");
        }

        return (firstNumber / secondNumber);
    }
}
