namespace SocialMediaForDevs.DTO.Dtos;

public record UpdatePostRequest(
    string Content,
    string ImgUrl,
    string CodeSnippet
);
