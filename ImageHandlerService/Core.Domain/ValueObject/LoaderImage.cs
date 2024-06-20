using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain.ValueObject;

public record LoaderImage(
    ID LoaderId,
    Dir ImagePath,
    Name ImageName);
