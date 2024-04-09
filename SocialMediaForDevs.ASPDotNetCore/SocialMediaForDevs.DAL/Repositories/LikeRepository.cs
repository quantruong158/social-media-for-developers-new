using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL.Repositories;

public class LikeRepository(SocialMediaDbContext _context) : ILikeRepository
{
    public Task<Like> CreateLikeAsync(Like like)
    {
        throw new NotImplementedException();
    }

    public Task<Like> DeleteLikeAsync(Like like)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetLikesCountByPostIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetUsersWhoLikedPostAsync(int postId)
    {
        throw new NotImplementedException();
    }
}
