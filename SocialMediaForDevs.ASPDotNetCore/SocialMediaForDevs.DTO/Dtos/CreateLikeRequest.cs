using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record CreateLikeRequest(
    [Required] int PostId,
    [Required] int UserId
);