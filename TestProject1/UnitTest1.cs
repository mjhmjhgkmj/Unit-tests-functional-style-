using PositiveNumber;
namespace TestProject1;
public class PositiveNumberExtensionsTests
{
    [Test]
    public void SquareRootShouldReturnSuccessWhenValidPositiveNumber() =>
        Assert.That(16.ToPositiveNumber().SquareRoot().IsSuccess);

    [Test]
    public void SquareRootShouldReturnSuccessWhenValidPositiveReal() =>
         Assert.That(16.5.ToPositiveNumber().SquareRoot().IsSuccess);

    [Test]
    public void SquareRootShouldReturnFailureWhenUnsupportedType() =>
        Assert.That('A'.ToPositiveNumber().SquareRoot().IsFailure);

    [Test]
    public void SquareRootShouldReturnFailureWhenNegativeNumber() =>
        Assert.That((-16).ToPositiveNumber().SquareRoot().IsFailure);
}