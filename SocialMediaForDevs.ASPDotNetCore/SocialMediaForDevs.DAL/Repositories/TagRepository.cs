using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class TagRepository(SocialMediaDbContext _context) : ITagRepository
{
    public async Task CreateTagAsync(Tag tag)
    {
        await _context.Tags.AddAsync(tag);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTagAsync(int id)
    {
        await _context.Tags.Where(tag => tag.Id == id).ExecuteDeleteAsync();
    }

    public async Task<List<Tag>> GetSearchTagsAsync(string search)
    {
        return await _context.Tags.Where(tag => tag.Name.Contains(search)).ToListAsync();
    }

    public async Task<Tag?> GetTagByIdAsync(int id)
    {
        var tag = await _context.Tags.FindAsync(id);
        return tag;
    }

    public async Task<List<Tag>> GetTagsAsync()
    {
        return await _context.Tags.ToListAsync();
    }

    public async Task UpdateTagAsync(Tag tag)
    {
        var existingTag = await _context.Tags.FindAsync(tag.Id);
        if (existingTag is null)
        {
            return;
        }
        _context.Entry(existingTag).CurrentValues.SetValues(tag);

        await _context.SaveChangesAsync();
    }
}
