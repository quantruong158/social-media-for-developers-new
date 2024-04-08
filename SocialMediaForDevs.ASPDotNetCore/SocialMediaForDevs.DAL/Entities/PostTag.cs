﻿namespace SocialMediaForDevs.DAL.Entities;

public class PostTag
{
    public int PostId { get; set; }
    public Post Post { get; set; } = default!;
    public int TagId { get; set; }
    public Tag Tag { get; set; } = default!;
}
