using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.BLL.Services.Mapping;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class PostService(IPostRepository _repo) : IPostService
{
    public async Task CreatePostAsync(CreatePostRequest createPostRequest)
    {
        await _repo.CreatePostAsync(createPostRequest.ToEntity(), createPostRequest.TagIds);
    }

    public async Task DeletePostAsync(int postId)
    {
        await _repo.DeletePostAsync(postId);
    }

    public async Task<IEnumerable<PostResponse>> GetFeedPostsByUserIdAsync(int userId)
    {
        var posts = await _repo.GetFeedPostsByUserIdAsync(userId);
        var postResponses = posts.Select(p => p.ToPostResponse(userId));
        return postResponses;
        
    }

    public async Task<PostResponse?> GetPostByIdAsync(int postId)
    {
        var post = await _repo.GetPostByIdAsync(postId);
        if (post is null)
        {
            return null;
        }

        return post.ToPostResponse(post.User.Id);
    }

    public async Task<IEnumerable<PostResponse>> GetPostsByUserIdAsync(int userId)
    {
        var posts = await _repo.GetPostsByUserIdAsync(userId);
        return posts.Select(p => p.ToPostResponse(userId));
    }

    public async Task UpdatePostAsync(int id, UpdatePostRequest updatePostRequest)
    {
        await _repo.UpdatePostAsync(updatePostRequest.ToEntity(id));
    }
}
