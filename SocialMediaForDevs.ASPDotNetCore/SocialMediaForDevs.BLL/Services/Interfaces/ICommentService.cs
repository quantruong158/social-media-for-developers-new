using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentResponse>> GetCommentsForPostAsync(int postId);
    
}
