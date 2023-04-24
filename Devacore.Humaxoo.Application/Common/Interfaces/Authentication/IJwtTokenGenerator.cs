using Devacore.Humaxoo.Domain.Entities;

namespace Devacore.Humaxoo.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}