using Devacore.Humaxoo.Domain.Entities;

namespace Devacore.Humaxoo.Application.Common.Interfaces.Persistence;

public interface ISubscriptionRepository
{
    Subscription? GetSubscriptionByEmail(string email);
    void Add(Subscription subscription);
}