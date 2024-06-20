namespace Core.Application.Handler;

public interface IHandler
{
    object GetInfo(string path);

    bool Create(string path);
    bool Replace(string sourcePath, string destinationPath);
    bool Delete(string path);
}