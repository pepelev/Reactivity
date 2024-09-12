namespace Reactivity.Input;

public abstract class Input
{
    protected Input(Input? left, Input? right)
    {
        left?.Dependent.Add(this);
        right?.Dependent.Add(this);
    }

    protected Input()
    {
    }

    private List<Input> Dependent { get; } = [];
    protected Action<int> Update => value => Dependent.ForEach(d => d.Set(value));
    public int Value { get; protected set; }

    public abstract void Set(int value);
}