using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface ITagRepository
{
    Task<List<Tag>> GetTagsAsync();
    Task<Tag?> GetTagByIdAsync(int id);
    Task CreateTagAsync(Tag tag);
    Task UpdateTagAsync(int id, Tag tag);
    Task DeleteTagAsync(int id);
    Task<List<Tag>> GetSearchTagsAsync(string search);
}
