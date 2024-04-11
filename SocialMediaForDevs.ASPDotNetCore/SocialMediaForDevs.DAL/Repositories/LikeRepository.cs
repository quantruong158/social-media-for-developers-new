using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class LikeRepository(SocialMediaDbContext _context) : ILikeRepository
{
    public async Task CreateLikeAsync(Like like)
    {
        await _context.Like.AddAsync(like);
    }

    public async Task DeleteLikeAsync(Like like)
    {
        _context.Like.Remove(like);
        await _context.SaveChangesAsync();
    }

    public async Task<int> GetLikesCountByPostIdAsync(int postId)
    {
        return await _context.Like
            .CountAsync(like => like.PostId == postId);
    }

    public async Task<List<User>> GetUsersWhoLikedPostAsync(int postId)
    {
        return await _context.Like
            .Where(like => like.PostId == postId)
            .Select(like => like.User)
            .ToListAsync();
    }
}
