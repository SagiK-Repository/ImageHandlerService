using Core.Domain.ValueObject;

namespace Core.Domain.Entity;

public class ImageGroupLoaderInfo
{
    public ID ImageGroupId { get; set; } = new(0);
    public ID LoaderId { get; set; } = new(0);
}
