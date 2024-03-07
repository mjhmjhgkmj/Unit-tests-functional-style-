using CSharpFunctionalExtensions;
namespace PositiveNumber;
public static class PositiveNumberExtensions
{
    public static Result<PositiveNumber<T>, string> ToPositiveNumber<T>(this T value) where T : struct, IComparable<T> =>
        ! (typeof(T) == typeof(double) || typeof(T) == typeof(float) || typeof(T) == typeof(decimal) || typeof(T) == typeof(int))
        ? Result.Failure<PositiveNumber<T>, string>($"{typeof(T)} is not a Real number")
        : value.CompareTo(default) <= 0
            ? Result.Failure<PositiveNumber<T>, string>("Value must be positive")
            : Result.Success<PositiveNumber<T>, string>(new PositiveNumber<T>(value));

    public static Result<double, string> SquareRoot<T>(this Result<PositiveNumber<T>, string> result) where T : struct, IComparable<T> =>
         result.Map(positiveNumber => Math.Sqrt(Convert.ToDouble(positiveNumber.Value)));
    public record PositiveNumber<T>(T Value) where T : struct, IComparable<T>;
}