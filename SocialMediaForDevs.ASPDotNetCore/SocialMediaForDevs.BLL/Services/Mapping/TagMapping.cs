using Npgsql.Replication;
using SocialMediaForDevs.DAL.Entities;
using SocialMediaForDevs.DTO.Dtos;

namespace SocialMediaForDevs.BLL.Services.Mapping;

public static class TagMapping
{
    public static Tag ToEntity(this CreateTagRequest createTagRequest)
    {
        return new Tag
        {
            Name = createTagRequest.Name
        };
    }
    public static TagResponse ToTagResponse(this Tag tag)
    {
        return new TagResponse(tag.Id, tag.Name);
    }
}
