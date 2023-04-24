namespace Devacore.Humaxoo.Contracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);

