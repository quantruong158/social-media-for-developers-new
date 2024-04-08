namespace SocialMediaForDevs.DAL.Entities;

public class Follow
{
    public int UserId { get; set; }
    public User Followee { get; set; } = default!;
    public int FollowerId { get; set; }
    public User Follower { get; set; } = default!;
}
