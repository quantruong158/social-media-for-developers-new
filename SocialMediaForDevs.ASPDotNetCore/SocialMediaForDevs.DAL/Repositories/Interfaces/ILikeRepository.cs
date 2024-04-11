using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface ILikeRepository
{
    Task<List<User>> GetUsersWhoLikedPostAsync(int postId);
    Task<int> GetLikesCountByPostIdAsync(int postId);
    Task CreateLikeAsync(Like like);
    Task DeleteLikeAsync(Like like);
}
