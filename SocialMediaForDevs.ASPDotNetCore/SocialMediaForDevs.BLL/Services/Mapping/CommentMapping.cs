using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class CommentMapping
{
    public static Comment ToEntity(this CreateCommentRequest createCommentRequest) {
        return new Comment
        {
            Content = createCommentRequest.Content,
            ImgUrl = createCommentRequest.ImgUrl,
            CodeSnippet = createCommentRequest.CodeSnippet,
            UserId = createCommentRequest.UserId,
            PostId = createCommentRequest.PostId
        };
    }

    public static CommentResponse ToCommentResponse(this Comment comment) {
        return new CommentResponse(
            comment.Id,
            comment.Content,
            comment.User.UserName!,
            comment.User.ImgUrl,
            comment.User.Email!,
            comment.CreatedAt,
            comment.UpdatedAt,
            comment.ImgUrl,
            comment.CodeSnippet
        );
    }
}
