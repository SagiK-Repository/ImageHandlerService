namespace Core.Application.Message.Message;

public interface IMessageBrocker
{
    bool PublishMessage(string message);
    bool Subscribe(string channel);
    bool Unsubscribe(string channel);
    string ReceiveMessage();
}
