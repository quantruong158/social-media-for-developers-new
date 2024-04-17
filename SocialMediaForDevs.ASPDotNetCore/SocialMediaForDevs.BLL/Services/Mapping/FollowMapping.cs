using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class FollowMapping
{
    public static Follow ToEntity(this CreateFollowRequest createFollowRequest)
    {
        return new Follow {
            UserId = createFollowRequest.FolloweeId,
            FollowerId = createFollowRequest.FollowerId
        };
    }
}
