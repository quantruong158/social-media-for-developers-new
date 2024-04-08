using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaForDevs.DAL.DatabaseContext;

namespace SocialMediaForDevs.DAL;

public static class DependencyInjection
{
    public static void AddDAL(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SocialMediaDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

    }
}