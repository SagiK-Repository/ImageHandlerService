using Core.Domain.ValueObject;

namespace Core.Domain.Entity;

public class ImageGroupTransformInfo
{
    public ID ImageGroupId { get; set; } = new(0);
    public ID TransformId { get; set; } = new(0);
}