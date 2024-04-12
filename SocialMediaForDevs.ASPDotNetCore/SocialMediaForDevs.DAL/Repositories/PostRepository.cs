using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class PostRepository(SocialMediaDbContext _context) : IPostRepository
{
    public async Task CreatePostAsync(Post post, List<int> tagIds)
    {
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
        await _context.PostTag.AddRangeAsync(tagIds.Select(tagId => new PostTag
        {
            PostId = post.Id,
            TagId = tagId
        }));
        await _context.SaveChangesAsync();
    }

    public async Task DeletePostAsync(int id)
    {
        await _context.Posts.Where(post => post.Id == id).ExecuteDeleteAsync();
    }

    public async Task<List<Post>> GetFeedPostsByUserIdAsync(int userId)
    {
        var posts = await _context.Posts
            .Include(p => p.Likes)
            .Include(p => p.User)
            .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
            .Where(p => _context.Follow
                .Where(f => f.FollowerId == userId)
                .Select(f => f.UserId)
                .Contains(p.UserId))
            .AsSplitQuery()
            .ToListAsync();

    return posts;
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        return await _context.Posts
            .Include(p => p.Likes)
            .Include(p => p.User)
            .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
            .AsSplitQuery()
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<Post>> GetPostsByUserIdAsync(int userId)
    {
        return await _context.Posts
            .Include(p => p.Likes)
            .Include(p => p.User)
            .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
            .AsSplitQuery()
            .Where(post => post.UserId == userId).ToListAsync();
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
