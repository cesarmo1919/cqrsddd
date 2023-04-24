using Devacore.Humaxoo.Application.Common.Persistence;
using Devacore.Humaxoo.Domain.Entities;
using Devacore.Humaxoo.Domain.Enums;
using Devacore.Humaxoo.Domain.Structures;
using Devacore.Humaxoo.Domain.Common.Errors;
using ErrorOr;
using MediatR;

namespace Devacore.Humaxoo.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<Guid>>
{
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<Guid>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        // 1. Validate the user doesn't exist
        if (_userRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }
        // 2. Create a Subscription
        var subscriptionId = Guid.NewGuid();

        // 3. Create an Agency
        var agencyId = Guid.NewGuid();

        // 4. Create the User
        var user = new User
        {
            SubscriptionId = subscriptionId,
            AgencyId = agencyId,
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Hash = "RandomPassword",
            PhoneNumber = new PhoneNumber
            {
                Code = "+33",
                Number = command.PhoneNumber
            },
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Roles = new Roles[] { Roles.OWNER },
            IsActive = false
        };

        // 5. Insert Into Database
        _userRepository.Add(user);

        // 6. Generate Activation Code
        // 7. Send Email with activation Code

        return user.Id;

    }
}