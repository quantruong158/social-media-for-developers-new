using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class FollowRepository(SocialMediaDbContext _context) : IFollowRepository
{
    public Task<Follow> CreateFollowAsync(Follow follow)
    {
        throw new NotImplementedException();
    }

    public Task<Follow> DeleteFollowAsync(Follow follow)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetFollowersByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetFollowersCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetFollowingByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetFollowingCountByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetUsersRecommendedToFollowAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsFollowingAsync(int followerId, int followingId)
    {
        throw new NotImplementedException();
    }
}
