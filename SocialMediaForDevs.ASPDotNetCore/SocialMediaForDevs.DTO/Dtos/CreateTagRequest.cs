using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record CreateTagRequest(
    [Required] string Name
);
