﻿using Microsoft.AspNetCore.Identity;

namespace SocialMediaForDevs.DAL.Entities;

public class User : IdentityUser<int>
{
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public string? ImgUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public List<Post> Posts { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
    public List<Like> Likes { get; set; } = [];
    public List<Follow> Followees { get; set; } = [];
    public List<Follow> Followers { get; set; } = [];
}