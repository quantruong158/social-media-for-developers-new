using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api")]
public class FollowController(IFollowService _followService) : ControllerBase
{
    [HttpPost("follows")]
    public async Task<IActionResult> FollowUser([FromBody] CreateFollowRequest followRequest)
    {
        await _followService.FollowUserAsync(followRequest);
        return Ok();
    }
    [HttpPost("unfollows")]
    public async Task<IActionResult> UnfollowUser([FromBody] CreateFollowRequest unfollowRequest)
    {
        await _followService.UnfollowUserAsync(unfollowRequest.FollowerId, unfollowRequest.FolloweeId);
        return Ok();
    }
}
