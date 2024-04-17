using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.BLL.Services.Mapping;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class LikeService(ILikeRepository _repo) : ILikeService
{
    public async Task<IEnumerable<UserResponse>> GetUsersWhoLikedPostAsync(int postId)
    {
        return (await _repo.GetUsersWhoLikedPostAsync(postId)).Select(u => u.ToUserResponse());
    }

    public async Task LikePostAsync(CreateLikeRequest createLikeRequest)
    {
        await _repo.CreateLikeAsync(createLikeRequest.ToEntity());
    }

    public async Task UnlikePostAsync(int userId, int postId)
    {
        var likeToDelete = new Like
        {
            UserId = userId,
            PostId = postId
        };
        await _repo.DeleteLikeAsync(likeToDelete);
    }
}
