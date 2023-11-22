using DinnerNow.Application.Authentication;
using DinnerNow.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DinnerNow.Api.Controllers;

[ApiController]
[Route("auth")]

public class AuthenticationController : ControllerBase{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService){
        _authenticationService = authenticationService;
    }

    [HttpPost("Register")]
    public IActionResult Register(RegisterRequest request){
        var authResponse = _authenticationService.Register(
            request.firstName, 
            request.lastName, 
            request.email, 
            request.password);
        var response = new Contracts.Authentication.AuthenticationResponse(
            authResponse.email,
            authResponse.id,
            authResponse.firstName,
            authResponse.lastName,
            authResponse.token
        );
        return Ok(response);
    }

    [HttpPost("Login")]
    public IActionResult Login(LoginRequest request){
        var authResponse = _authenticationService.Login(
            request.email, 
            request.password);
        var response = new Contracts.Authentication.AuthenticationResponse(
            authResponse.email,
            authResponse.id,
            authResponse.firstName,
            authResponse.lastName,
            authResponse.token
        );
        return Ok(response);
    }
}