using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface IPostRepository
{
    Task<IEnumerable<Post>> GetFeedPostsByUserIdAsync(int userId);
    Task<IEnumerable<Post>> GetPostsByUserIdAsync(int userId);
    Task<Post> GetPostByIdAsync(int id);
    Task<Post> CreatePostAsync(Post post);
    Task<Post> UpdatePostAsync(Post post);
    Task<Post> DeletePostAsync(int id);
}
