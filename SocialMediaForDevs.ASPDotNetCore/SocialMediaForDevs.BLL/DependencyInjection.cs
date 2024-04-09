using Microsoft.Extensions.DependencyInjection;
using SocialMediaForDevs.BLL.Services;
using SocialMediaForDevs.BLL.Services.Interfaces;

namespace SocialMediaForDevs.BLL
{
    public static class DependencyInjection
    {
        public static void AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IFollowService, FollowService>();
            services.AddScoped<ITagService, TagService>();
        }
    }
}
