using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Interfaces;

public interface ITagService
{
    Task<IEnumerable<TagResponse>> GetTagsAsync();
    Task<TagResponse> GetTagByIdAsync(int tagId);
    Task CreateTagAsync(CreateTagRequest createTagRequest);
    Task DeleteTagAsync(int tagId);
    Task<IEnumerable<TagResponse>> GetSearchTagsAsync(string search);
}
