using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaForDevs.DAL.DatabaseContext;
using SocialMediaForDevs.DAL.Repositories;
using SocialMediaForDevs.DAL.Repositories.Interfaces;

namespace SocialMediaForDevs.DAL;

public static class DependencyInjection
{
    public static void AddDAL(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<ILikeRepository, LikeRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IFollowRepository, FollowRepository>();
        services.AddScoped<ITagRepository, TagRepository>();

        services.AddDbContext<SocialMediaDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

    }
}