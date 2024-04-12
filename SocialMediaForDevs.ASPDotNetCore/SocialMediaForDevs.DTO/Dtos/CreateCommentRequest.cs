using System.ComponentModel.DataAnnotations;

namespace SocialMediaForDevs.DTO.Dtos;

public record CreateCommentRequest(
    [Required] string Content,
    [Required] int UserId,
    [Required] int PostId,
    string ImgUrl,
    string CodeSnippet
);
