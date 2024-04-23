using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
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
    private static string GenerateRefreshToken()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
    public string GenerateJwtTokenAsync(string email)
    {
        var claims = new List<Claim> {
            new(ClaimTypes.Name, email)
        };
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        SigningCredentials signingCred = new(securityKey, SecurityAlgorithms.HmacSha256Signature);
        SecurityToken securityToken = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddSeconds(30),
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            signingCredentials: signingCred
        );
        string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
        return tokenString;
    }

    public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
    {
        var user = await _userManager.FindByEmailAsync(loginRequest.Email);
        if (user == null || !await _userManager.CheckPasswordAsync(user, loginRequest.Password))
        {
            return new LoginResponse(false, "", "");
        }
        string refreshToken = GenerateRefreshToken();
        user.RefreshToken = refreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddHours(24);
        await _userManager.UpdateAsync(user);

        return new LoginResponse(true, GenerateJwtTokenAsync(loginRequest.Email), refreshToken);
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

    public async Task<LoginResponse> RefreshAsync(RefreshRequest refreshRequest)
    {
        var principal = GetTokenPrincipal(refreshRequest.JwtToken);
        if (principal?.Identity?.Name is null)
        {
            return new LoginResponse(false, "", "");
        }

        var user = await _userManager.FindByEmailAsync(principal.Identity.Name);
        if (user is null || user.RefreshToken != refreshRequest.RefreshToken || DateTime.UtcNow > user.RefreshTokenExpiryTime)
        {
            return new LoginResponse(false, "", "");
        }

        string newRefreshToken = GenerateRefreshToken();
        user!.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddHours(24);
        await _userManager.UpdateAsync(user);

        return new LoginResponse(true, GenerateJwtTokenAsync(user.Email!), newRefreshToken);
    }

    private ClaimsPrincipal? GetTokenPrincipal(string token)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var validation = new TokenValidationParameters
        {
            ValidateActor = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _config["Jwt:Issuer"],
            ValidAudience = _config["Jwt:Issuer"],
            IssuerSigningKey = securityKey
        };
        return new JwtSecurityTokenHandler().ValidateToken(token, validation, out _);
    }
}
