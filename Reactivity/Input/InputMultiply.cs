namespace Reactivity.Input;

public sealed class InputMultiply(Input left, Input right) : Input(left, right)
{
    public override void Set(int value)
    {
        Value = left.Value * right.Value;
        Update(Value);
    }
}