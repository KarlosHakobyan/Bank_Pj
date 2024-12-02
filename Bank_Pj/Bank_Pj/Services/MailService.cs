namespace Bank_Pj.Services
{
    public class MailService : IMessageService
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Email to {recipient}: {message}");
        }
    }
}
