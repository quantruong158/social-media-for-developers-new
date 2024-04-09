using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.Repositories.Interfaces;

public interface ITagRepository
{
    Task<IEnumerable<Tag>> GetTagsAsync();
    Task<Tag> GetTagByIdAsync(int id);
    Task<Tag> CreateTagAsync(Tag tag);
    Task<Tag> UpdateTagAsync(Tag tag);
    Task<Tag> DeleteTagAsync(int id);
    Task<IEnumerable<Tag>> GetSearchTagsAsync(string search);
}
