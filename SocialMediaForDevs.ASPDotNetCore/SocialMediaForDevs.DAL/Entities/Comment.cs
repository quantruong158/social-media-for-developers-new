using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace SocialMediaForDevs.DAL.Entities;

public class Comment
{
    public int Id { get; set; }
    [Column(TypeName = "text")]
    public string Content { get; set; } = default!;
    public string ImgUrl { get; set; } = default!;
    [Column(TypeName = "text")]
    public string CodeSnippet { get; set; } = default!;
    [Column(TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Column(TypeName = "timestamp with time zone")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public int PostId { get; set; }
    public Post Post { get; set; } = default!;
}
