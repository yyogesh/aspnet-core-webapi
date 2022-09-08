using Microsoft.AspNetCore.Mvc;
using YDinner.Contracts.Authentication;

namespace YDinner.API.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [Route("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [Route("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}