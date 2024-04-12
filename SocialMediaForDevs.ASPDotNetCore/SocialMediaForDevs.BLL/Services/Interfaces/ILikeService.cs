using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface ILikeService
{
    Task<IEnumerable<UserResponse>> GetUsersWhoLikedPostAsync(int postId);
    Task LikePostAsync(CreateLikeRequest createLikeRequest);
    Task UnlikePostAsync(int userId, int postId);
}
