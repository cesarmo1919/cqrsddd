using Devacore.Humaxoo.Contracts.Authentication;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Devacore.Humaxoo.Domain.Common.Errors;
using MediatR;
using Devacore.Humaxoo.Application.Authentication.Commands.Register;
using Devacore.Humaxoo.Application.Authentication.Queries.Login;

namespace Devacore.Humaxoo.Api.Controllers;

[Route("/api/auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;

    public AuthenticationController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.PhoneNumber,
            request.Country,
            request.CompanyName,
            request.CompanySize);

        ErrorOr<Guid> registerResult = await _mediator.Send(command);

        return registerResult.Match(
            response => Ok(response),
            errors => Problem(errors)
        );
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(request.Email, request.Password);

        var authResult = await _mediator.Send(query);

        if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized, title: authResult.FirstError.Description);
        }

        return authResult.Match(
            response => Ok(new AuthenticationResponse(
                authResult.Value.User.Id,
                authResult.Value.User.SubscriptionId,
                authResult.Value.User.AgencyId,
                authResult.Value.User.FirstName,
                authResult.Value.User.LastName,
                authResult.Value.User.Email,
                authResult.Value.Token
            )),
            errors => Problem(errors)
        );
    }
}