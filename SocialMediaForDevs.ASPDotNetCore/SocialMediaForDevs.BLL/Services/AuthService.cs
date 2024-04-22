using Microsoft.AspNetCore.Identity;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class AuthService(UserManager<User> _userManager) : IAuthService
{
    public async Task<IdentityResult> RegisterAsync(RegisterRequest registerRequest)
    {
        var user = new User
        {
            UserName = registerRequest.UserName,
            Email = registerRequest.Email
        };
        Console.WriteLine(user.UserName);

        var result = await _userManager.CreateAsync(user, registerRequest.Password);

        return result;
    }
}
