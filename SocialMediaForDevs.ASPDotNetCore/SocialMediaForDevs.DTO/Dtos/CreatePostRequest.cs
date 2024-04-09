using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record CreatePostRequest(
    [Required] string Content,
    [Required] int UserId,
    string ImgUrl,
    string CodeSnippet,
    [Required] List<int> TagIds
);
