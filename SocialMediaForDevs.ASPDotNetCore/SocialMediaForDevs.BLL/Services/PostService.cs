using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class PostService : IPostService
{
    public Task CreatePostAsync(CreatePostRequest createPostRequest)
    {
        throw new NotImplementedException();
    }

    public Task DeletePostAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostResponse>> GetFeedPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<PostResponse> GetPostByIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostResponse>> GetPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePostAsync(UpdatePostRequest updatePostRequest)
    {
        throw new NotImplementedException();
    }
}
