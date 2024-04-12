using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class LikeService(ILikeRepository _repo) : ILikeService
{
    public async Task<IEnumerable<UserResponse>> GetUsersWhoLikedPostAsync(int postId)
    {
        return (await _repo.GetUsersWhoLikedPostAsync(postId)).Select(u => new UserResponse(
            u.Id,
            u.Username,
            u.Email,
            u.ImgUrl
        ));
    }

    public async Task LikePostAsync(CreateLikeRequest createLikeRequest)
    {
        var like = new Like
        {
            UserId = createLikeRequest.UserId,
            PostId = createLikeRequest.PostId
        };
        await _repo.CreateLikeAsync(like);
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
