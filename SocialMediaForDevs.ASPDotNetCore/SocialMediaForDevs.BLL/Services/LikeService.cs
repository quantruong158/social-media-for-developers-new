using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class LikeService(ILikeRepository _repo) : ILikeService
{
    public async Task<IEnumerable<UserResponse>> GetUsersWhoLikedPostAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public async Task LikePostAsync(int userId, int postId)
    {
        throw new NotImplementedException();
    }

    public async Task UnlikePostAsync(int userId, int postId)
    {
        throw new NotImplementedException();
    }
}
