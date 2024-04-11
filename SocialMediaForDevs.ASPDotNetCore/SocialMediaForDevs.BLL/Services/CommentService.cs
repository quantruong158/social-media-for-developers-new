using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class CommentService(ICommentRepository _repo) : ICommentService
{
    public async Task CreateCommentAsync(CreateCommentRequest createCommentRequest)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteCommentAsync(int commentId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CommentResponse>> GetCommentsForPostAsync(int postId)
    {
        throw new NotImplementedException();
    }
    
}
