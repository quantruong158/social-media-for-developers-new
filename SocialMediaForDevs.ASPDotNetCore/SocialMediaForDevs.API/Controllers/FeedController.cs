using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api/feeds")]
public class FeedController(IPostService _postService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetFeed([FromQuery] int? userId)
    {
        if (!userId.HasValue)
        {
            return BadRequest("User id is required");
        }
        var posts = await _postService.GetFeedPostsByUserIdAsync(userId.Value);
        return Ok(posts);
    }
}
