using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class FollowRepository(SocialMediaDbContext _context) : IFollowRepository
{
    public async Task CreateFollowAsync(Follow follow)
    {
        await _context.Follow.AddAsync(follow);
    }

    public async Task DeleteFollowAsync(Follow follow)
    {
        _context.Follow.Remove(follow);
        await _context.SaveChangesAsync();
    }

    public async Task<List<User>> GetFollowersByUserIdAsync(int userId)
    {
        return await _context.Follow
            .Where(follow => follow.UserId == userId)
            .Select(follow => follow.Follower)
            .ToListAsync();
    }

    public async Task<int> GetFollowersCountByUserIdAsync(int userId)
    {
        return await _context.Follow
            .CountAsync(follow => follow.UserId == userId);
    }

    public async Task<List<User>> GetFollowingByUserIdAsync(int userId)
    {
        return await _context.Follow
            .Where(follow => follow.FollowerId == userId)
            .Select(follow => follow.Followee)
            .ToListAsync();
    }

    public async Task<int> GetFollowingCountByUserIdAsync(int userId)
    {
        return await _context.Follow
            .CountAsync(follow => follow.FollowerId == userId);
    }

    public async Task<List<User>> GetUsersRecommendedToFollowAsync(int userId)
    {
        var user = await _context.Users
            .Include(u => u.Followers)
            .FirstOrDefaultAsync(u => u.Id == userId);

        var followerIds = user!.Followers.Select(f => f.FollowerId);

        var usersRecommendedToFollow = await _context.Users
            .Where(u => u.Id != userId && !followerIds.Contains(u.Id))
            .ToListAsync();

        return usersRecommendedToFollow;
    }

    public async Task<bool> IsFollowingAsync(int followerId, int followingId)
    {
        return await _context.Follow
            .AnyAsync(follow => follow.FollowerId == followerId && follow.UserId == followingId);
    }
}
