namespace Bank_Pj.Services
{
    public class SmsService : IMessageService
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"SMS to {recipient}: {message}");
        }
    }
}
