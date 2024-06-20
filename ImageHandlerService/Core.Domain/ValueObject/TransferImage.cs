using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain.ValueObject;

public record TransferImage(
    ID TransferId,
    Dir TargetFilePath,
    Name TargetFileName);