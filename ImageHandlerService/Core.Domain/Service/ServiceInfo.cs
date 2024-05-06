using Core.Domain.Loader;
using Core.Domain.Transfer;
using Core.Domain.Transform;
using Core.Domain.ValueObject;

namespace Core.Domain.Service;

public class ServiceInfo : Detail, IService
{
    public ID Id { get; set; } = new(0);

    public IList<ImageGroup> ImageGroups { get; set; } = [];

    //public IList<IService> Services { get; set; } = [];
    public IList<LoaderInfo> LoaderInfos { get; set; } = [];

    public IList<TransformInfo> TransformInfos { get; set; } = [];

    public IList<TransferInfo> TransferInfos { get; set; } = [];

}