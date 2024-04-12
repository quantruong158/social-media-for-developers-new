using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public class FollowService(IFollowRepository _repo) : IFollowService
{
    public async Task FollowUserAsync(CreateFollowRequest createFollowRequest)
    {
        var newFollow = new Follow {
            UserId = createFollowRequest.FolloweeId,
            FollowerId = createFollowRequest.FollowerId
        };
        await _repo.CreateFollowAsync(newFollow);
    }

    public async Task<IEnumerable<UserResponse>> GetFollowersByUserIdAsync(int userId)
    {
        var followers = await _repo.GetFollowersByUserIdAsync(userId);
        return followers.Select(f => new UserResponse
        (f.Id,
         f.Username,
         f.Email,
         f.ImgUrl
        ));
    }

    public async Task<int> GetFollowersCountByUserIdAsync(int userId)
    {
        return await _repo.GetFollowersCountByUserIdAsync(userId);
    }

    public async Task<IEnumerable<UserResponse>> GetFollowingByUserIdAsync(int userId)
    {
        var following = await _repo.GetFollowingByUserIdAsync(userId);
        return following.Select(f => new UserResponse
        (f.Id,
         f.Username,
         f.Email,
         f.ImgUrl
        ));
    }

    public async Task<int> GetFollowingCountByUserIdAsync(int userId)
    {
        return await _repo.GetFollowingCountByUserIdAsync(userId);
    }

    public async Task<IEnumerable<UserResponse>> GetSuggestedFolloweeAsync(int userId)
    {
        var suggestedFollowees = await _repo.GetUsersRecommendedToFollowAsync(userId);
        return suggestedFollowees.Select(f => new UserResponse
        (f.Id,
         f.Username,
         f.Email,
         f.ImgUrl
        ));
    }

    public async Task<bool> IsFollowingAsync(int followerId, int followingId)
    {
        return await _repo.IsFollowingAsync(followerId, followingId);
    }

    public async Task UnfollowUserAsync(int followerId, int followingId)
    {
        var followToDelete = new Follow {
            UserId = followingId,
            FollowerId = followerId
        };
        await _repo.DeleteFollowAsync(followToDelete);
    }
}
