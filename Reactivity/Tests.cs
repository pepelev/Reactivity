using FluentAssertions;
using NUnit.Framework;
using Reactivity.Input;

namespace Reactivity;

public sealed class Tests
{
    [Test]
    public void DEqualAPlusBC()
    {
        // let d = a + b * c;
        var a = new AtomicInput();
        var b = new AtomicInput();
        var c = new AtomicInput();
        var d = new Output();
        var aplucBC = (Output output) =>  AplusBCInput.Create(a, b, c, output);
        d.Subscribe(aplucBC);

        
        a.Set(2);
        d.Received.Should().Equal(2);
        
        b.Set(3);
        d.Received.Should().Equal(2, 2);

        c.Set(6);
        d.Received.Should().Equal(2, 2, 20);

        a.Set(5);
        d.Received.Should().Equal(2, 2, 20, 23);
    }
}