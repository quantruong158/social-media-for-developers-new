namespace SocialMediaForDevs.DAL.Entities;

public class Post
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public List<Comment> Comments { get; set; } = [];
    public List<Like> Likes { get; set; } = [];
    public List<PostTag> PostTags { get; set; } = [];
}
