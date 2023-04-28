namespace DotnetSample.App;

public class CalculatorService
{
    private double _currentValue;

    public void Add(double operand)
    {
        _currentValue += operand;
    }

    public void Subtract(double operand)
    {
        _currentValue -= operand;
    }

    public double Result()
    {
        return _currentValue;
    }

    public void Clear()
    {
        _currentValue = 0;
    }
}