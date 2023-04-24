using Devacore.Humaxoo.Domain.Entities;

namespace Devacore.Humaxoo.Application.Common;

public record AuthenticationResult(
    User User,
    string Token
);