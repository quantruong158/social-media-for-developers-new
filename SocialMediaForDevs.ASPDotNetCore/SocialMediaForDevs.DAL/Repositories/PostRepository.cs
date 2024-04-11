using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class PostRepository(SocialMediaDbContext _context) : IPostRepository
{
    public async Task CreatePostAsync(Post post)
    {
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePostAsync(int id)
    {
        await _context.Posts.Where(post => post.Id == id).ExecuteDeleteAsync();
    }

    public async Task<List<Post>> GetFeedPostsByUserIdAsync(int userId)
    {
        var user = await _context.Users
            .Include(u => u.Followers)
            .FirstOrDefaultAsync(u => u.Id == userId);

        var followerIds = user!.Followers.Select(f => f.FollowerId);

        var posts = await _context.Posts
            .Where(p => followerIds.Contains(p.UserId))
            .ToListAsync();

        return posts;
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _context.Posts.FindAsync(id);
    }

    public async Task<List<Post>> GetPostsByUserIdAsync(int userId)
    {
        return await _context.Posts.Where(post => post.UserId == userId).ToListAsync();
    }

    public async Task UpdatePostAsync(Post post)
    {
        var existingPost = await _context.Posts.FindAsync(post.Id);
        if (existingPost is null)
        {
            return;
        }
        _context.Entry(existingPost).CurrentValues.SetValues(post);

        await _context.SaveChangesAsync();
    }
}
