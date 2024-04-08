namespace SocialMediaForDevs.DAL.Entities;

public class Tag
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<PostTag> PostTags { get; set; } = [];
}
