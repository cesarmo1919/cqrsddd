using Devacore.Humaxoo.Domain.Entities;

namespace Devacore.Humaxoo.Application.Common.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}