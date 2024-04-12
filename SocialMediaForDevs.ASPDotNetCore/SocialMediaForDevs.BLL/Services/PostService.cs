using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class PostService(IPostRepository _repo) : IPostService
{
    public async Task CreatePostAsync(CreatePostRequest createPostRequest)
    {
        var post = new Post
        {
            Content = createPostRequest.Content,
            ImgUrl = createPostRequest.ImgUrl,
            CodeSnippet = createPostRequest.CodeSnippet,
            UserId = createPostRequest.UserId
        };
        await _repo.CreatePostAsync(post, createPostRequest.TagIds);
    }

    public async Task DeletePostAsync(int postId)
    {
        await _repo.DeletePostAsync(postId);
    }

    public async Task<IEnumerable<PostResponse>> GetFeedPostsByUserIdAsync(int userId)
    {
        var posts = await _repo.GetFeedPostsByUserIdAsync(userId);
        var postResponses = posts.Select(p => new PostResponse
        (p.Id,
         p.Content,
         p.ImgUrl,
         p.CodeSnippet,
         p.User.Username,
         p.User.ImgUrl,
         p.User.Email,
         p.Likes.Any(l => l.UserId == userId),
         p.CreatedAt,
         p.UpdatedAt,
         p.PostTags.Select(pt => new TagResponse(
             pt.Tag.Id,
             pt.Tag.Name
         ))
        ));

    return postResponses;
        
    }

    public async Task<PostResponse?> GetPostByIdAsync(int postId)
    {
        var post = await _repo.GetPostByIdAsync(postId);
        if (post is null)
        {
            return null;
        }

        return new PostResponse
        (post.Id,
         post.Content,
         post.ImgUrl,
         post.CodeSnippet,
         post.User.Username,
         post.User.ImgUrl,
         post.User.Email,
         post.Likes.Count != 0,
         post.CreatedAt,
         post.UpdatedAt,
         post.PostTags.Select(pt => new TagResponse(
             pt.Tag.Id,
             pt.Tag.Name
         ))
        );
    }

    public async Task<IEnumerable<PostResponse>> GetPostsByUserIdAsync(int userId)
    {
        var posts = await _repo.GetPostsByUserIdAsync(userId);
        return posts.Select(p => new PostResponse
        (p.Id,
         p.Content,
         p.ImgUrl,
         p.CodeSnippet,
         p.User.Username,
         p.User.ImgUrl,
         p.User.Email,
         p.Likes.Any(l => l.UserId == userId),
         p.CreatedAt,
         p.UpdatedAt,
         p.PostTags.Select(pt => new TagResponse(
             pt.Tag.Id,
             pt.Tag.Name
         ))
        ));
    }

    public async Task UpdatePostAsync(int id, UpdatePostRequest updatePostRequest)
    {
        var post = new Post
        {
            Id = id,
            Content = updatePostRequest.Content,
            ImgUrl = updatePostRequest.ImgUrl,
            CodeSnippet = updatePostRequest.CodeSnippet
        };
        await _repo.UpdatePostAsync(post);
    }
}
