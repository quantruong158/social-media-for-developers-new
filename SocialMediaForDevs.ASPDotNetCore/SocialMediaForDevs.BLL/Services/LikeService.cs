using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class LikeService : ILikeService
{
    public Task<IEnumerable<UserResponse>> GetUsersWhoLikedPostAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task LikePostAsync(int userId, int postId)
    {
        throw new NotImplementedException();
    }

    public Task UnlikePostAsync(int userId, int postId)
    {
        throw new NotImplementedException();
    }
}
