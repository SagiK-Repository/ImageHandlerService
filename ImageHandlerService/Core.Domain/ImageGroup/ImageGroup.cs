using Core.Domain.Service;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain;

public class ImageGroup : Detail
{
    public ID Id { get; set; } = null!;
    public Name Name { get; set; } = new(string.Empty);
    public List<Image> Images { get; set;} = [];

    public List<IService> Services { get; set; } = [];
}
