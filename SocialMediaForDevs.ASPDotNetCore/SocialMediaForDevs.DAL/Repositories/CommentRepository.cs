using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class CommentRepository(SocialMediaDbContext _context) : ICommentRepository
{
    public Task<Comment> CreateCommentAsync(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> DeleteCommentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> GetCommentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> UpdateCommentAsync(Comment comment)
    {
        throw new NotImplementedException();
    }
}