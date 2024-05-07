using Core.Domain.ValueObject;

namespace Core.Domain.Entity;

public class ImageGroupTransferInfo
{
    public ID ImageGroupId { get; set; } = new(0);
    public ID TransferId { get; set; } = new(0);
}
