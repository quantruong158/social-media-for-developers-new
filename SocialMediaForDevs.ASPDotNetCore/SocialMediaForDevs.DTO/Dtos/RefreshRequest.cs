namespace SocialMediaForDevs.DTO.Dtos;

public record RefreshRequest(
    string JwtToken,
    string RefreshToken
);
