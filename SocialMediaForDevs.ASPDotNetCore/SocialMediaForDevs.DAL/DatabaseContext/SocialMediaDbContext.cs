using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMediaForDevs.DAL.Entities;

namespace SocialMediaForDevs.DAL.DatabaseContext;
public class SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options) : IdentityDbContext<User, IdentityRole<int>, int>(options)
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Like> Like { get; set; }
    public DbSet<PostTag> PostTag { get; set; }
    public DbSet<Follow> Follow { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = 1, Name = "c#" },
            new Tag { Id = 2, Name = "exp" },
            new Tag { Id = 3, Name = "meme" },
            new Tag { Id = 4, Name = "q&a" },
            new Tag { Id = 5, Name = "news" }
        );
        modelBuilder.Entity<Like>().HasKey(l => new { l.UserId, l.PostId });
        modelBuilder.Entity<PostTag>().HasKey(p => new { p.PostId, p.TagId });
        modelBuilder.Entity<Follow>().HasKey(f => new { f.UserId, f.FollowerId });

        modelBuilder.Entity<Like>()
            .HasOne(l => l.User)
            .WithMany(u => u.Likes)
            .HasForeignKey(l => l.UserId);
        modelBuilder.Entity<Like>()
            .HasOne(l => l.Post)
            .WithMany(p => p.Likes)
            .HasForeignKey(l => l.PostId);

        modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Post)
            .WithMany(p => p.PostTags)
            .HasForeignKey(pt => pt.PostId);
        modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.PostTags)
            .HasForeignKey(pt => pt.TagId);

        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Followee)
            .WithMany(u => u.Followers)
            .HasForeignKey(f => f.UserId);

        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Follower)
            .WithMany(u => u.Followees)
            .HasForeignKey(f => f.FollowerId);
    }

}
