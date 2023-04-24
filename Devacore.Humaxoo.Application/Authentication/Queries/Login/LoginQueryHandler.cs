using Devacore.Humaxoo.Application.Common.Persistence;
using Devacore.Humaxoo.Domain.Entities;
using Devacore.Humaxoo.Domain.Common.Errors;
using ErrorOr;
using MediatR;
using Devacore.Humaxoo.Application.Authentication.Queries.Login;
using Devacore.Humaxoo.Application.Common.Interfaces.Authentication;
using Devacore.Humaxoo.Application.Common;

namespace Devacore.Humaxoo.Application.Authentication.Commands.Register;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {

        // 1. Validate if user exists
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // 2. Validate Password
        if (user.Hash != query.Password)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // 3. Return the login credentials
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );

    }
}