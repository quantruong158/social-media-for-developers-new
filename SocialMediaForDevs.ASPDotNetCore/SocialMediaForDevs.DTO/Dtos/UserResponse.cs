namespace SocialMediaForDevs.DTO.Dtos;

public record class UserResponse(
    int Id,
    string Username,
    string Email,
    string? ImgUrl
);
