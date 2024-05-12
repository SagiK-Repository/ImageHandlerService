namespace Core.Application.Common.Connection;

public interface IConnectionable
{
    bool Connect();
    bool DisConnect();
    bool IsConnected { get; }
}
