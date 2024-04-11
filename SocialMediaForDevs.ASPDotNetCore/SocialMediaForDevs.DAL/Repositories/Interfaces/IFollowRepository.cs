using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface IFollowRepository
{
    Task<List<User>> GetFollowersByUserIdAsync(int userId);
    Task<List<User>> GetFollowingByUserIdAsync(int userId);
    Task<int> GetFollowersCountByUserIdAsync(int userId);
    Task<int> GetFollowingCountByUserIdAsync(int userId);
    Task<bool> IsFollowingAsync(int followerId, int followingId);
    Task CreateFollowAsync(Follow follow);
    Task DeleteFollowAsync(Follow follow);
    Task<List<User>> GetUsersRecommendedToFollowAsync(int userId);
}
