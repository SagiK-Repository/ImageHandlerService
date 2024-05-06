namespace ImageHandlerService.Core.Domain.ValueObject;

public record FileSize
{
    private const long MinValue = 0;
    private const long MaxValue = 1024 * 1024 * 1024; // 1GB

    private readonly long _value;

    public FileSize() { }
    public FileSize(long value)
    {
        if (value < MinValue || value > MaxValue)
            throw new ArgumentOutOfRangeException(nameof(value), $"Value must be between {MinValue} and {MaxValue} bytes. FileSize is {value}");

        _value = value;
    }

    public long Bytes => _value;
}