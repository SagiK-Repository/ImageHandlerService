namespace Core.Application.Handler;

public interface IAsyncHandler
{
    Task<object> GetInfoAsync(string path);

    Task<bool> CreateAsync(string path);
    Task<bool> ReplaceAsync(string sourcePath, string destinationPath);
    Task<bool> DeleteAsync(string path);
}
