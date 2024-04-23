using Core.Domain.Service;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;
using System.Drawing;

namespace Core.Domain.Transform;

public class TransformInfo : Detail, IService
{
    public ID Id { get; set; } = new(0);

    public Size Size { get; set; } = new(0, 0);
    public FileType FileType { get; set; } = new(string.Empty);

    public IList<ImageGroup> ImageGroups { get; set; } = [];
    public ServiceInfo ServiceInfo { get; set; } = null!;
}