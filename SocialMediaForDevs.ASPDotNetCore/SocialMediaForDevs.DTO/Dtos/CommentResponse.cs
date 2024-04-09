namespace SocialMediaForDevs.DTO.Dtos;

public record CommentResponse(
    int Id,
    string Content,
    string Username,
    string UserImgUrl,
    string Email,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    string ImgUrl,
    string CodeSnippet
);
