using Devacore.Humaxoo.Domain.Enums;

namespace Devacore.Humaxoo.Domain.Structures;

public class Plan
{
    public SubscriptionTypes Type { get; set; }
    public Currenies Currency { get; set; } = Currenies.EUR;
    public decimal PricePerMonth { get; set; }
    public decimal PricePerYear { get; set; }
    public int Period { get; set; }
    public string Description { get; set; } = null!;
}