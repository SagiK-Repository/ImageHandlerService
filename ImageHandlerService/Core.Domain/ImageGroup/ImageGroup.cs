using Core.Domain.Loader;
using Core.Domain.Transfer;
using Core.Domain.Transform;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain;

public class ImageGroup : Detail
{
    public ID Id { get; set; } = null!;
    public Name Name { get; set; } = new(string.Empty);
    public IList<Image> Images { get; set; } = [];

    //public IList<IService> Services { get; set; } = [];
    public IList<LoaderInfo> LoaderInfos { get; set; } = [];

    public IList<TransformInfo> TransformInfos { get; set; } = [];

    public IList<TransferInfo> TransferInfos { get; set; } = [];
}
