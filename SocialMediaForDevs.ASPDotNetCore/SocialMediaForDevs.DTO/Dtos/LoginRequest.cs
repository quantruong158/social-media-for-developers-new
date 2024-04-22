using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO;

public record LoginRequest(
    [Required] string Email,
    [Required] string Password
);