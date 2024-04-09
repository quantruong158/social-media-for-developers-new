using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class TagRepository(SocialMediaDbContext _context) : ITagRepository
{
    public Task<Tag> CreateTagAsync(Tag tag)
    {
        throw new NotImplementedException();
    }

    public Task<Tag> DeleteTagAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tag>> GetSearchTagsAsync(string search)
    {
        throw new NotImplementedException();
    }

    public Task<Tag> GetTagByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tag>> GetTagsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Tag> UpdateTagAsync(Tag tag)
    {
        throw new NotImplementedException();
    }
}
