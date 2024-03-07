using PositiveNumber;
namespace TestProject1;
public class PositiveNumberExtensionsTests
{
    [Test]
    public void SquareRoot_ShouldReturnSuccess_WhenValidPositiveNumber() =>
        Assert.That(16.ToPositiveNumber().SquareRoot().IsSuccess);

    [Test]
    public void SquareRoot_ShouldReturnFailure_WhenUnsupportedType() =>
        Assert.That('A'.ToPositiveNumber().SquareRoot().IsFailure);

    [Test]
    public void SquareRoot_ShouldReturnFailure_WhenNegativeNumber() =>
        Assert.That((-16).ToPositiveNumber().SquareRoot().IsFailure);
}