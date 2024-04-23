namespace SocialMediaForDevs.DTO.Dtos;

public record LoginResponse(
    bool IsLoggedIn,
    string JwtToken,
    string RefreshToken
);
