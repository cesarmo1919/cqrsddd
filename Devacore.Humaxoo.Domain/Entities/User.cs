using Devacore.Humaxoo.Domain.Enums;
using Devacore.Humaxoo.Domain.Structures;

namespace Devacore.Humaxoo.Domain.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SubscriptionId { get; set; } = Guid.NewGuid();
    public Guid AgencyId { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Roles[] Roles { get; set; } = new Roles[] { Enums.Roles.OWNER };
    public string Email { get; set; } = null!;
    public string Hash { get; set; } = null!;
    public PhoneNumber PhoneNumber { get; set; } = new PhoneNumber();
    public Boolean IsActive { get; set; } = false;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}