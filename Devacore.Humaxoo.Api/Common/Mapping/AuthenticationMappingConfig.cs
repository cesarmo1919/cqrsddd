using Devacore.Humaxoo.Application.Authentication.Commands.Register;
using Devacore.Humaxoo.Application.Authentication.Queries.Login;
using Devacore.Humaxoo.Application.Common;
using Devacore.Humaxoo.Contracts.Authentication;
using Mapster;

namespace Devacore.Humaxoo.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}