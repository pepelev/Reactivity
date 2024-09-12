namespace Reactivity;

public static class OutputExtensions
{
    public static void Subscribe(this Output output, Func<Output, Input.Input> formula) => formula(output);
}