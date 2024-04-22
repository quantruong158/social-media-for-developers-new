using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record RegisterRequest(
    [Required] string UserName,
    [Required][EmailAddress] string Email,
    [Required] string Password
);