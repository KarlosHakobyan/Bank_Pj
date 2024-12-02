using Bank_Pj.Services;

namespace BankAccountNotification
{
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string recipient, string message)
        {
            _messageService.Send(recipient, message);
        }
    }
}
