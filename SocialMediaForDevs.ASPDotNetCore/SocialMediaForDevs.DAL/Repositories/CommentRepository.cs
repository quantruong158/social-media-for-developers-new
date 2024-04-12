using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class CommentRepository(SocialMediaDbContext _context) : ICommentRepository
{
    public async Task CreateCommentAsync(Comment comment)
    {
        await _context.Comments.AddAsync(comment);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCommentAsync(int id)
    {
        await _context.Comments.Where(comment => comment.Id == id).ExecuteDeleteAsync();
    }

    public async Task<Comment?> GetCommentByIdAsync(int id)
    {
        return await _context.Comments
        .Include(c => c.User)
        .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<List<Comment>> GetCommentsByPostIdAsync(int postId)
    {
        return await _context.Comments.Where(comment => comment.PostId == postId).Include(c => c.User).ToListAsync();
    }

    public async Task UpdateCommentAsync(Comment comment)
    {
        var existingComment = await _context.Comments.FindAsync(comment.Id);
        if (existingComment is null)
        {
            return;
        }
        _context.Entry(existingComment).CurrentValues.SetValues(comment);

        await _context.SaveChangesAsync();
    }
}