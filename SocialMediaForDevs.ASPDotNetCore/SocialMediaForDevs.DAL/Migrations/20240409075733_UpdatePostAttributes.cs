using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMediaForDevs.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePostAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeSnippet",
                table: "Posts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Posts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeSnippet",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Posts");
        }
    }
}
