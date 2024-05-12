namespace Core.Application.Handler;

public interface IAsyncHandler
{
    Task<object> GetInfo(string path);

    Task<bool> Create(string path);
    Task<bool> Rename(string path);
    Task<bool> Delete(string path);
}
