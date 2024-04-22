using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class PostMapping
{
    public static Post ToEntity(this CreatePostRequest createPostRequest)
    {
        return new Post
        {
            Content = createPostRequest.Content,
            ImgUrl = createPostRequest.ImgUrl,
            CodeSnippet = createPostRequest.CodeSnippet,
            UserId = createPostRequest.UserId
        };
    }
    public static Post ToEntity(this UpdatePostRequest updatePostRequest, int id)
    {
        return new Post
        {
            Id = id,
            Content = updatePostRequest.Content,
            ImgUrl = updatePostRequest.ImgUrl,
            CodeSnippet = updatePostRequest.CodeSnippet
        };
    }

    public static PostResponse ToPostResponse(this Post post, int userId)
    {
        return new PostResponse(
            post.Id,
            post.Content,
            post.ImgUrl,
            post.CodeSnippet,
            post.User.UserName!,
            post.User.ImgUrl,
            post.User.Email!,
            post.Likes.Any(l => l.UserId == userId),
            post.CreatedAt,
            post.UpdatedAt,
            post.PostTags.Select(pt => new TagResponse(
                pt.Tag.Id,
                pt.Tag.Name
            ))
        );
    }
}
