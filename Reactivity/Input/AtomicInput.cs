namespace Reactivity.Input;

public class AtomicInput : Input
{
    public override void Set(int value)
    {
        Value = value;
        Update(Value);
    }
}