using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface IPostService
{
    Task<IEnumerable<PostResponse>> GetFeedPostsByUserIdAsync(int userId);
    Task<IEnumerable<PostResponse>> GetPostsByUserIdAsync(int userId);
    Task<PostResponse?> GetPostByIdAsync(int postId);
    Task CreatePostAsync(CreatePostRequest createPostRequest);
    Task UpdatePostAsync(UpdatePostRequest updatePostRequest);
    Task DeletePostAsync(int postId);
}
