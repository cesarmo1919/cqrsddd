using ErrorOr;
using MediatR;

namespace Devacore.Humaxoo.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string CompanyName,
    string CompanySize
) : IRequest<ErrorOr<Guid>>;