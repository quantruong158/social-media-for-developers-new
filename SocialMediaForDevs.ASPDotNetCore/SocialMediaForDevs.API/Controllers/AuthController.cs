using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[Controller]
[Route("api/account")]
public class AuthController(IAuthService _authService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
    {
        var result = await _authService.RegisterAsync(registerRequest);
        if (result.Succeeded)
        {
            return Ok();
        }
        return BadRequest(result.Errors);
    }
}
