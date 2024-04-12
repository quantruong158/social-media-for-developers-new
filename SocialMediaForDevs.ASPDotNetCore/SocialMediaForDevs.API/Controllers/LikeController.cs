using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api/posts")]
public class LikeController(ILikeService _likeService) : ControllerBase
{
    [HttpPost("likes")]
    public async Task<IActionResult> LikePost([FromBody] CreateLikeRequest likeRequest)
    {
        await _likeService.LikePostAsync(likeRequest);
        return Ok();
    }
    [HttpPost("unlikes")]
    public async Task<IActionResult> UnlikePost([FromBody] CreateLikeRequest unlikeRequest)
    {
        await _likeService.UnlikePostAsync(unlikeRequest.UserId, unlikeRequest.PostId);
        return Ok();
    }
}
