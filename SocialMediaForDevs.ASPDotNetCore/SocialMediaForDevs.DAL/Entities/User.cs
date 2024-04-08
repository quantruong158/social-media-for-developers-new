namespace SocialMediaForDevs.DAL.Entities;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string ImgUrl { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public List<Post> Posts { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
    public List<Like> Likes { get; set; } = [];
    public List<Follow> Followees { get; set; } = [];
    public List<Follow> Followers { get; set; } = [];
}