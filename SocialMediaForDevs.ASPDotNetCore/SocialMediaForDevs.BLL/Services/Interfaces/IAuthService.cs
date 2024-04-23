using Microsoft.AspNetCore.Identity;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterRequest registerRequest);
    Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    string GenerateJwtTokenAsync(string email);
    Task<LoginResponse> RefreshAsync(RefreshRequest refreshRequest);
}
