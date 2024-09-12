namespace Reactivity.Input;

public sealed class AplusBCInput : Input
{
    private readonly Output output;
    public static Input Create(Input a, Input b, Input c, Output output)
        => new AplusBCInput(b.Multiply(c).Sum(a), output);
    
    private AplusBCInput(Input input, Output output) : base(input, null)
    {
        this.output = output;
    }

    public override void Set(int value)
    {
        Value = value;
        //Update(Value);
        output.Update(value);
    }
}