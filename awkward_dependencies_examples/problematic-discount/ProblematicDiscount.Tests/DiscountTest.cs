using NUnit.Framework;

namespace ProblematicDiscount.Tests;

public class DiscountTest
{

    [Test]
    public void Fix_Me()
    {
        var discount = new Discount();

        var net = new Money(110);
        var total = discount.DiscountFor(net);

        Assert.That(new Money(104.5m), Is.EqualTo(total));
    }
    
    
}