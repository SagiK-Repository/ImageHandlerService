namespace Core.UseCase.Serializer.Serializer;

public interface ISerializer
{
    object Deserialize(string target, Type targetType);
    object Serialize(object input, Type targetType);

    Task<object> DeserializeAsync(string target, Type targetType);
    Task<object> SerializeAsync(object value, Type targetType);
}