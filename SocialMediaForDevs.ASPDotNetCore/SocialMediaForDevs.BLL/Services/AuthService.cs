using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class AuthService(UserManager<User> _userManager, IConfiguration _config) : IAuthService
{
    public string GenerateJwtTokenAsync(LoginRequest user)
    {
        var claims = new List<Claim> {
            new(ClaimTypes.Email, user.Email!)
        };
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        SigningCredentials signingCred = new(securityKey, SecurityAlgorithms.HmacSha256Signature);
        SecurityToken securityToken = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            signingCredentials: signingCred
        );
        string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
        return tokenString;
    }

    public async Task<bool> LoginAsync(LoginRequest loginRequest)
    {
        var user = await _userManager.FindByEmailAsync(loginRequest.Email);
        if (user == null)
        {
            return false;
        }
        return await _userManager.CheckPasswordAsync(user, loginRequest.Password);
    }

    public async Task<IdentityResult> RegisterAsync(RegisterRequest registerRequest)
    {
        var user = new User
        {
            UserName = registerRequest.UserName,
            Email = registerRequest.Email
        };

        var result = await _userManager.CreateAsync(user, registerRequest.Password);

        return result;
    }
}
