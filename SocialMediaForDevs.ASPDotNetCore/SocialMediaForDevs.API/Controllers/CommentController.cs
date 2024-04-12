using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api/comments")]
public class CommentController(ICommentService _commentService) : ControllerBase
{
    [HttpGet("{commentId}")]
    public async Task<IActionResult> GetComment(int commentId)
    {
        var comment = await _commentService.GetCommentByIdAsync(commentId);
        if (comment is null)
        {
            return NotFound();
        }
        return Ok(comment);
    }
    [HttpGet]
    public async Task<IActionResult> GetCommentsOfPost([FromQuery] int? postId)
    {
        if (postId is null)
        {
            return BadRequest();
        }
        var comments = await _commentService.GetCommentsOfPostAsync(postId.Value);
        return Ok(comments);
    }
    [HttpPost]
    public async Task<IActionResult> CreateComment([FromBody] CreateCommentRequest createCommentRequest)
    {
        await _commentService.CreateCommentAsync(createCommentRequest);
        return Ok();
    }
}
