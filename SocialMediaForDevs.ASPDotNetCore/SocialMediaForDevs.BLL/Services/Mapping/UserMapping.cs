using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class UserMapping
{
    public static UserResponse ToUserResponse(this User user)
    {
        return new UserResponse(
            user.Id,
            user.Username,
            user.Email,
            user.ImgUrl
        );
    }
}
