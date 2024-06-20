using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain.ValueObject;

public record TransformImage(
    ID TransformId,
    Dir ImagePath,
    Name ImageName);
