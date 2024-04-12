using Microsoft.AspNetCore.Mvc;
using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.API.Controllers;

[ApiController]
[Route("api/tags")]
public class TagController(ITagService _tagService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTags()
    {
        var tags = await _tagService.GetTagsAsync();
        return Ok(tags);
    }

    [HttpGet("{tagId}")]
    public async Task<IActionResult> GetTagById(int tagId)
    {
        var tag = await _tagService.GetTagByIdAsync(tagId);
        return Ok(tag);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTag([FromBody] CreateTagRequest createTagRequest)
    {
        await _tagService.CreateTagAsync(createTagRequest);
        return Ok();
    }
}
