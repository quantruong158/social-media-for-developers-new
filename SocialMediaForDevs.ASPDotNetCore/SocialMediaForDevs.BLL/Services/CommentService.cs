using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class CommentService(ICommentRepository _repo) : ICommentService
{
    public async Task CreateCommentAsync(CreateCommentRequest createCommentRequest)
    {
        var comment = new Comment
        {
            Content = createCommentRequest.Content,
            ImgUrl = createCommentRequest.ImgUrl,
            CodeSnippet = createCommentRequest.CodeSnippet,
            UserId = createCommentRequest.UserId,
            PostId = createCommentRequest.PostId
        };
        await _repo.CreateCommentAsync(comment);
    }

    public async Task DeleteCommentAsync(int commentId)
    {
        await _repo.DeleteCommentAsync(commentId);
    }

    public async Task<CommentResponse?> GetCommentByIdAsync(int commentId)
    {
        var comment = await _repo.GetCommentByIdAsync(commentId);
        if (comment is null)
        {
            return null;
        }
        return new CommentResponse
        (comment.Id,
         comment.Content,
         comment.User.Username,
         comment.User.ImgUrl,
         comment.User.Email,
         comment.CreatedAt,
         comment.UpdatedAt,
         comment.ImgUrl,
         comment.CodeSnippet
        );
    }

    public async Task<IEnumerable<CommentResponse>> GetCommentsOfPostAsync(int postId)
    {
        var comments = await _repo.GetCommentsByPostIdAsync(postId);
        return comments.Select(c => new CommentResponse
        (c.Id,
         c.Content,
         c.User.Username,
         c.User.ImgUrl,
         c.User.Email,
         c.CreatedAt,
         c.UpdatedAt,
         c.ImgUrl,
         c.CodeSnippet
        ));
    }
    
}
