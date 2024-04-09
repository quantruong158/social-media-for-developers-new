using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface ILikeRepository
{
    Task<IEnumerable<User>> GetUsersWhoLikedPostAsync(int postId);
    Task<int> GetLikesCountByPostIdAsync(int postId);
    Task<Like> CreateLikeAsync(Like like);
    Task<Like> DeleteLikeAsync(Like like);
}
