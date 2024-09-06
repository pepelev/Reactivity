using FluentAssertions;
using NUnit.Framework;

namespace Reactivity;

public sealed class Tests
{
    [Test]
    public void DEqualAPlusBC()
    {
        // let d = a + b * c;
        Input a = null!;
        Input b = null!;
        Input c = null!;
        Output d = null!;
        
        a.Set(2);
        d.Received.Should().Equal(0);
        
        b.Set(3);
        d.Received.Should().Equal(0, 0);

        c.Set(6);
        d.Received.Should().Equal(0, 0, 20);

        a.Set(5);
        d.Received.Should().Equal(0, 0, 20, 23);
    }
}