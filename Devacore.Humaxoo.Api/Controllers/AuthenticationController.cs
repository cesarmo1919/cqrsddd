using Devacore.Humaxoo.Contracts.Authentication;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Devacore.Humaxoo.Domain.Common.Errors;
using MediatR;
using Devacore.Humaxoo.Application.Authentication.Commands.Register;
using Devacore.Humaxoo.Application.Authentication.Queries.Login;
using MapsterMapper;

namespace Devacore.Humaxoo.Api.Controllers;

[Route("/api/auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterCommand>(request);

        ErrorOr<Guid> registerResult = await _mediator.Send(command);

        return registerResult.Match(
            response => Ok(response),
            errors => Problem(errors)
        );
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = _mapper.Map<LoginQuery>(request);

        var authResult = await _mediator.Send(query);

        if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized, title: authResult.FirstError.Description);
        }

        return authResult.Match(
            response => Ok(_mapper.Map<AuthenticationResponse>(authResult.Value)),
            errors => Problem(errors)
        );
    }
}