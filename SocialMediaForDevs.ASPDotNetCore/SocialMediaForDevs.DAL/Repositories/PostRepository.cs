using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class PostRepository(SocialMediaDbContext _context) : IPostRepository
{
    public Task<Post> CreatePostAsync(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post> DeletePostAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetFeedPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetPostByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Post> UpdatePostAsync(Post post)
    {
        throw new NotImplementedException();
    }
}
