using DotnetSample.App;

namespace DotnetSample.Test;

public class CalculatorServiceTests
{
    private readonly CalculatorService _sut;

    public CalculatorServiceTests()
    {
        _sut = new CalculatorService();
    }

    [Fact]
    public void Add_AddsOperandToCurrentValue()
    {
        // Arrange
        _sut.Add(5);

        // Act
        _sut.Add(10);

        // Assert
        Assert.Equal(15, _sut.Result());
    }

    [Fact]
    public void Subtract_SubtractsOperandFromCurrentValue()
    {
        // Arrange
        _sut.Add(10);

        // Act
        _sut.Subtract(5);

        // Assert
        Assert.Equal(5, _sut.Result());
    }

    [Fact]
    public void Result_ReturnsCurrentValue()
    {
        // Arrange
        _sut.Add(10);

        // Act
        var result = _sut.Result();

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Clear_ResetsCurrentValueToZero()
    {
        // Arrange
        _sut.Add(10);

        // Act
        _sut.Clear();

        // Assert
        Assert.Equal(0, _sut.Result());
    }
    
    [Fact]
    public void False_is_true()
    {
        Assert.Equal(true, false == true);
    }
}