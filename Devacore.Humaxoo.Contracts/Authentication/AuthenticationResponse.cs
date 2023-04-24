namespace Devacore.Humaxoo.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    Guid SubscriptionId,
    Guid AgencyId,
    string FirstName,
    string LastName,
    string Email,
    string Token
);

