using Devacore.Humaxoo.Application.Common.Interfaces.Services;

namespace Devacore.Humaxoo.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}