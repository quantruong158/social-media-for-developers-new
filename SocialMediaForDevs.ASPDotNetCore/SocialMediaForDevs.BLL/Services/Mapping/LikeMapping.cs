using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class LikeMapping
{
    public static Like ToEntity(this CreateLikeRequest createLikeRequest)
    {
        return new Like
        {
            UserId = createLikeRequest.UserId,
            PostId = createLikeRequest.PostId
        };
    }
}
