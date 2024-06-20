using Core.Application.Handler;

namespace Core.UseCase.Handler.Handler;

public interface IDirectoryHandler : IHandler, IAsyncHandler
{
    string Read(string path);

    IEnumerable<string> ReadFile(string Path);

    bool Copy(string sourcePath, string destPath, bool overwrite);
    bool Move(string sourcePath, string destPath, bool overwrite);
    bool Exist(string path);
    bool ExistFile(string Path);

    Task<string> ReadAsync(string path);

    Task<IEnumerable<string>> ReadFileAsync(string Path);

    Task<bool> CopyAsync(string sourcePath, string destPath, bool overwrite);
    Task<bool> MoveAsync(string sourcePath, string destPath, bool overwrite);
    Task<bool> ExistAsync(string path);
    Task<bool> ExistFileAsync(string Path);
}