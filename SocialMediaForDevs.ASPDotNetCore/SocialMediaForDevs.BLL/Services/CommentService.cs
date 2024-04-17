using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.BLL.Services.Mapping;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class CommentService(ICommentRepository _repo) : ICommentService
{
    public async Task CreateCommentAsync(CreateCommentRequest createCommentRequest)
    {
        await _repo.CreateCommentAsync(createCommentRequest.ToEntity());
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
        return comment.ToCommentResponse();
    }

    public async Task<IEnumerable<CommentResponse>> GetCommentsOfPostAsync(int postId)
    {
        var comments = await _repo.GetCommentsByPostIdAsync(postId);
        return comments.Select(c => c.ToCommentResponse());
    }
    
}
