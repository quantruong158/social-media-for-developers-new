using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface IFollowService
{
    Task<IEnumerable<UserResponse>> GetFollowersByUserIdAsync(int userId);
    Task<IEnumerable<UserResponse>> GetFollowingByUserIdAsync(int userId);
    Task<int> GetFollowersCountByUserIdAsync(int userId);
    Task<int> GetFollowingCountByUserIdAsync(int userId);
    Task FollowUserAsync(int followerId, int followingId);
    Task UnfollowUserAsync(int followerId, int followingId);
    Task<bool> IsFollowingAsync(int followerId, int followingId);
    Task<IEnumerable<UserResponse>> GetSuggestedFolloweeAsync(int userId);
}
