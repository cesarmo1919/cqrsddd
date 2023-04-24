namespace Devacore.Humaxoo.Contracts.Authentication;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string CompanyName,
    string CompanySize
);