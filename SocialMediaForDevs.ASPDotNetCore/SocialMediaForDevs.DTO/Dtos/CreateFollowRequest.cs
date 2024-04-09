using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record CreateFollowRequest(
    [Required] int FollowerId,
    [Required] int FolloweeId
);
