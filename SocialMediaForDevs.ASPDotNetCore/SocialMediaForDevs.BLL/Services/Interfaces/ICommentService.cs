using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentResponse>> GetCommentsOfPostAsync(int postId);
    Task CreateCommentAsync(CreateCommentRequest createCommentRequest);
    Task DeleteCommentAsync(int commentId);
    Task<CommentResponse?> GetCommentByIdAsync(int commentId);
}
