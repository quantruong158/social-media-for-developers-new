using SocialMediaForDevs.BLL.Services.Interfaces;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services;

public class TagService : ITagService
{
    public Task CreateTagAsync(CreateTagRequest createTagRequest)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTagAsync(int tagId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TagResponse>> GetSearchTagsAsync(string search)
    {
        throw new NotImplementedException();
    }

    public Task<TagResponse> GetTagByIdAsync(int tagId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TagResponse>> GetTagsAsync()
    {
        throw new NotImplementedException();
    }
}
