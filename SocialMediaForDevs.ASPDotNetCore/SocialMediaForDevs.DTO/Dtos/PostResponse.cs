namespace SocialMediaForDevs.DTO.Dtos;

public record PostResponse(
    int Id,
    string Content,
    string ImgUrl,
    string CodeSnippet,
    string Username,
    string UserImgUrl,
    string Email,
    bool IsLiked,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    IEnumerable<TagResponse> Tags
);