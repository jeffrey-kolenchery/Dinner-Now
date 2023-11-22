namespace DinnerNow.Application.Authentication;

public interface IAuthenticationService
{
    AuthenticationResponse Register(string firstName, string lastName, string email, string password);
    AuthenticationResponse Login(string email, string password);
}