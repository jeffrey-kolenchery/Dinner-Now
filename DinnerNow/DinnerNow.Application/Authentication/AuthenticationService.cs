namespace DinnerNow.Application.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(
            Guid.NewGuid(), 
            "firstName", 
            "lastName",
            email,
            "token"
        );
    }

    public AuthenticationResponse Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResponse(
            Guid.NewGuid(), 
            firstName, 
            lastName,
            email,
            "token"
        );
    }
}
