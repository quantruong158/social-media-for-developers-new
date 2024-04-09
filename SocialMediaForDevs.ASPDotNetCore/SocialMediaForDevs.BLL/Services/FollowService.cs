using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public class FollowService : IFollowService
{
    public Task FollowUserAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserResponse>> GetFollowersByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetFollowersCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserResponse>> GetFollowingByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetFollowingCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsFollowingAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }

    public Task UnfollowUserAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }
}
