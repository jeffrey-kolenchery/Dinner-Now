namespace DinnerNow.Contracts.Authentication;

public record AuthenticationResponse(
    string Email,
    Guid Id,
    string FirstName,
    string LastName,
    string Token
);