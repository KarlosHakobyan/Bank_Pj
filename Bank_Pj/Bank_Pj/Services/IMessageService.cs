namespace Bank_Pj.Services
{
    public interface IMessageService
    {
        void Send(string recipient, string message);
    }
}
