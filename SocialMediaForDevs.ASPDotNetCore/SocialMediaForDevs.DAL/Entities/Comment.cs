using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaForDevs.DAL.Entities;

public class Comment
{
    public int Id { get; set; }
    [Column(TypeName = "text")]
    public string Content { get; set; } = default!;
    public string ImgUrl { get; set; } = default!;
    [Column(TypeName = "text")]
    public string CodeSnippet { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public int PostId { get; set; }
    public Post Post { get; set; } = default!;
}
