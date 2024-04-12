using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface IPostRepository
{
    Task<List<Post>> GetFeedPostsByUserIdAsync(int userId);
    Task<List<Post>> GetPostsByUserIdAsync(int userId);
    Task<Post?> GetPostByIdAsync(int id);
    Task CreatePostAsync(Post post, List<int> tagIds);
    Task UpdatePostAsync(Post post);
    Task DeletePostAsync(int id);
}
