namespace Core.Application.Handler;

public interface IHandler
{
    object GetInfo(string path);

    bool Create(string path);
    bool Rename(string path);
    bool Delete(string path);
}