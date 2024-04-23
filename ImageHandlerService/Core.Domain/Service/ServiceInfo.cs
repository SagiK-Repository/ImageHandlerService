using Core.Domain.ValueObject;

namespace Core.Domain.Service;

public class ServiceInfo : Detail
{
    public ID Id { get; set; } = new(0);

    public List<Image> Images { get; set; } = [];
    public List<ImageGroup> ImageGroups { get; set; } = [];
    public List<IService> Services { get; set; } = [];
}
