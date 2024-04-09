using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class CommentService : ICommentService
{
    public Task<IEnumerable<CommentResponse>> GetCommentsForPostAsync(int postId)
    {
        throw new NotImplementedException();
    }
}
