using Devacore.Humaxoo.Application.Common;
using ErrorOr;
using MediatR;

namespace Devacore.Humaxoo.Application.Authentication.Queries.Login;

public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;