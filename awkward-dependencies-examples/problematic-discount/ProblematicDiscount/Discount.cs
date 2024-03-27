namespace ProblematicDiscount;

public class Discount
{
    private readonly MarketingCampaign _marketingCampaign;

    public Discount()
    {
        _marketingCampaign = new MarketingCampaign();
    }

    public Money DiscountFor(Money netPrice)
    {
        if (_marketingCampaign.IsCrazySalesDay())
        {
            return netPrice.ReduceBy(15);
        }
        if (netPrice.MoreThan(Money.OneThousand))
        {
            return netPrice.ReduceBy(10);
        }
        if (netPrice.MoreThan(Money.OneHundred) && _marketingCampaign.IsActive())
        {
            return netPrice.ReduceBy(5);
        }
        return netPrice;
    }
}