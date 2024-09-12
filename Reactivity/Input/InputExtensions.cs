namespace Reactivity.Input;

public static class InputExtensions
{
    public static Input Sum(this Input left, Input right) => new InputSum(left, right);
    public static Input Multiply(this Input left, Input right) => new InputMultiply(left, right);
}