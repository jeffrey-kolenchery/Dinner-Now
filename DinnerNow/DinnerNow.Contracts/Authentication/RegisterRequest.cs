namespace DinnerNow.Contracts.Authentication;

public record RegisterRequest(
    string email,
    string password,
    string firstName,
    string lastName
);