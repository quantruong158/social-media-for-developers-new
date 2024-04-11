using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public class FollowService(IFollowRepository _repo) : IFollowService
{
    public async Task FollowUserAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UserResponse>> GetFollowersByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetFollowersCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UserResponse>> GetFollowingByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetFollowingCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UserResponse>> GetSuggestedFolloweeAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsFollowingAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }

    public async Task UnfollowUserAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }
}
