using Microsoft.AspNetCore.Identity;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterRequest registerRequest);
    Task<bool> LoginAsync(LoginRequest loginRequest);
    string GenerateJwtTokenAsync(LoginRequest user);
}
