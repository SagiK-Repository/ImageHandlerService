using Core.Domain.Service;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain.Loader;

public class LoaderInfo : Detail, IService
{
    public ID Id { get; set; } = new(0);

    public Dir LookDir { get; set; } = new(string.Empty);
    public Dir ModeDir { get; set; } = new(string.Empty);
    public TimeSpan RepeatTime { get; set; }

    public IList<ImageGroup> ImageGroups { get; set; } = [];
    public ServiceInfo ServiceInfo { get; set; } = null!;
}
