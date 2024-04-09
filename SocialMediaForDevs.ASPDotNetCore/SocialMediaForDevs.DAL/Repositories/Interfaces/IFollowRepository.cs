using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface IFollowRepository
{
    Task<IEnumerable<User>> GetFollowersByUserIdAsync(int userId);
    Task<IEnumerable<User>> GetFollowingByUserIdAsync(int userId);
    Task<int> GetFollowersCountByUserIdAsync(int userId);
    Task<int> GetFollowingCountByUserIdAsync(int userId);
    Task<bool> IsFollowingAsync(int followerId, int followingId);
    Task<Follow> CreateFollowAsync(Follow follow);
    Task<Follow> DeleteFollowAsync(Follow follow);
    Task<IEnumerable<User>> GetUsersRecommendedToFollowAsync(int userId);
}
