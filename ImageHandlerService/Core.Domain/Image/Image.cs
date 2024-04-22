using ImageHandlerService.Core.Domain.ValueObject;

namespace Core.Domain;

public class Image
{
    public ID Id { get; set; } = null!;
    public Name Name { get; set; } = new(string.Empty);
    public FileType Type { get; set; } = new(string.Empty);
    public FileSize Size { get; set; } = new(0);
    public ImageGroup ImageGroup { get; set; } = null!;
}
