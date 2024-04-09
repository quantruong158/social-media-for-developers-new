using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaForDevs.DAL.Entities;

public class Post
{
    public int Id { get; set; }
    [Column(TypeName = "text")]
    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public string ImgUrl { get; set; } = default!;
    [Column(TypeName = "text")]
    public string CodeSnippet { get; set; } = default!;
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public List<Comment> Comments { get; set; } = [];
    public List<Like> Likes { get; set; } = [];
    public List<PostTag> PostTags { get; set; } = [];
}
