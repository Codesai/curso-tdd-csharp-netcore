namespace ProblematicDiscount;

public record Money
{
    public static readonly Money OneThousand = new(1000);

    public static readonly Money OneHundred = new(100);

    private readonly decimal _value;

    public Money(int value) => _value = value;

    public Money(decimal value) => _value = value;

    public Money ReduceBy(int p)
    {
        return new Money(_value * (100m - p) / 100m);
    }

    public bool MoreThan(Money other)
    {
        return _value.CompareTo(other._value) > 0;
    }

    public override string ToString()
    {
        return "Money { "+_value+" }";
    }
    
}