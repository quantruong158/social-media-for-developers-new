using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class PostService(IPostRepository _repo) : IPostService
{
    public async Task CreatePostAsync(CreatePostRequest createPostRequest)
    {
        throw new NotImplementedException();
    }

    public async Task DeletePostAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PostResponse>> GetFeedPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<PostResponse?> GetPostByIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PostResponse>> GetPostsByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task UpdatePostAsync(UpdatePostRequest updatePostRequest)
    {
        throw new NotImplementedException();
    }
}
