using Core.Application.Handler;

namespace Core.UseCase.Handler.Handler;
public interface IFileHandler : IHandler, IAsyncHandler
{
    string Read(string path);

    bool Copy(string sourcePath, string destPath, bool overwrite);
    bool Move(string sourcePath, string destPath, bool overwrite);
    bool Exist(string path);

    Task<string> ReadAsync(string path);

    Task<bool> CopyAsync(string sourcePath, string destPath, bool overwrite);
    Task<bool> MoveAsync(string sourcePath, string destPath, bool overwrite);
    Task<bool> ExistAsync(string path);
}