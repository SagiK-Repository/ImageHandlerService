namespace Core.Domain.ValueObject;

public record ID
{
    private const int _minValue = 0;
    private const int _maxValue = 100000;

    private readonly int _value;

    public ID() { }
    public ID(int value)
    {
        if (value < _minValue || value > _maxValue)
            throw new ArgumentOutOfRangeException(nameof(value), $"Value must be between {_minValue} and {_maxValue}. Is {value}");

        _value = value;
    }

    public int Value => _value;
}
