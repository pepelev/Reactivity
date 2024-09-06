namespace Reactivity;

public sealed class Output
{
    private readonly List<int> received = new();

    public void Update(int value)
    {
        received.Add(value);
    }
    
    public IEnumerable<int> Received => received;
}