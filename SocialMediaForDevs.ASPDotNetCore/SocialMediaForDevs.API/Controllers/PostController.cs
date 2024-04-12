using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController(IPostService _postService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPostsOfUser([FromQuery] int? userId)
    {
        if (userId is null)
        {
            return BadRequest();
        }
        var posts = await _postService.GetPostsByUserIdAsync(userId.Value);
        return Ok(posts);
    }

    [HttpGet("{postId}")]
    public async Task<IActionResult> GetPost(int postId)
    {
        var post = await _postService.GetPostByIdAsync(postId);
        if (post is null)
        {
            return NotFound();
        }
        return Ok(post);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] CreatePostRequest createPostRequest)
    {
        await _postService.CreatePostAsync(createPostRequest);
        return Ok();
    }
}
