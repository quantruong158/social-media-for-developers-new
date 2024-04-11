using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DAL.Repositories.Interfaces;
using SocialMediaForDevs.DTO.Dtos;
using System.Linq;

namespace SocialMediaForDevs.BLL.Services;

public class TagService(ITagRepository _tagRepository) : ITagService
{
    public async Task CreateTagAsync(CreateTagRequest createTagRequest)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteTagAsync(int tagId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TagResponse>> GetSearchTagsAsync(string search)
    {
        throw new NotImplementedException();
    }

    public async Task<TagResponse?> GetTagByIdAsync(int tagId)
    {
        var tag = await _tagRepository.GetTagByIdAsync(tagId);
        return new TagResponse(tag.Id, tag.Name);
    }

    public async Task<IEnumerable<TagResponse>> GetTagsAsync()
    {
        return (await _tagRepository.GetTagsAsync()).Select(tag => new TagResponse(tag.Id, tag.Name));
    }
}
