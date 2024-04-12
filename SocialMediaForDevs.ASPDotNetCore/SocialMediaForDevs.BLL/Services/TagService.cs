using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;
using System.Linq;

namespace SocialMediaForDevs.BLL.Services;

public class TagService(ITagRepository _tagRepository) : ITagService
{
    public async Task CreateTagAsync(CreateTagRequest createTagRequest)
    {
        var tag = new Tag
        {
            Name = createTagRequest.Name
        };
        await _tagRepository.CreateTagAsync(tag);
    }

    public async Task DeleteTagAsync(int tagId)
    {
        await _tagRepository.DeleteTagAsync(tagId);
    }

    public async Task<IEnumerable<TagResponse>> GetSearchTagsAsync(string search)
    {
        return (await _tagRepository.GetSearchTagsAsync(search)).Select(tag => new TagResponse(tag.Id, tag.Name));
    }

    public async Task<TagResponse?> GetTagByIdAsync(int tagId)
    {
        var tag = await _tagRepository.GetTagByIdAsync(tagId);
        if (tag is null)
        {
            return null;
        }
        return new TagResponse(tag.Id, tag.Name);
    }

    public async Task<IEnumerable<TagResponse>> GetTagsAsync()
    {
        return (await _tagRepository.GetTagsAsync()).Select(tag => new TagResponse(tag.Id, tag.Name));
    }
}
