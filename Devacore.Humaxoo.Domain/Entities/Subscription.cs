using Devacore.Humaxoo.Domain.Enums;
using Devacore.Humaxoo.Domain.Structures;

namespace Devacore.Humaxoo.Domain.Entities;

public class Subscription
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public SubscriptionStatus PreviousStatus { get; set; }
    public Boolean IsActive { get; set; }
    public Boolean IsSubscribed { get; set; }
    public string EmailSubscribedWith { get; set; } = null!;
    public string StripeCustomerId { get; set; } = null!;
    public DateTime BeginSubscriptionDate { get; set; }
    public DateTime? EndSubscriptionDate { get; set; }
    public UsageConso UsageConso { get; set; } = new UsageConso();
    public Plan Plan { get; set; } = new Plan();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}