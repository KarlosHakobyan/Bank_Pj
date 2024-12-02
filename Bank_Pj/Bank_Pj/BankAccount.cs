namespace BankAccountNotification
{
    public class BankAccount
    {
        private string _name;
        private string _accountNumber;
        private string _email;
        private string _phoneNumber;
        private decimal _balance;

        private readonly Notification _emailNotification;
        private readonly Notification _smsNotification;

        public BankAccount(Notification emailNotification, Notification smsNotification)
        {
            _emailNotification = emailNotification;
            _smsNotification = smsNotification;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyAll($"Name changed to: {_name}");
                }
            }
        }

        public string AccountNumber
        {
            get => _accountNumber;
            set
            {
                if (_accountNumber != value)
                {
                    _accountNumber = value;
                    NotifyAll($"Account number changed to: {_accountNumber}");
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    NotifyAll($"Email changed to: {_email}");
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    NotifyAll($"Phone number changed to: {_phoneNumber}");
                }
            }
        }

        public decimal Balance
        {
            get => _balance;
            set
            {
                if (_balance != value)
                {
                    _balance = value;
                    NotifyAll($"Balance changed to: {_balance}");
                }
            }
        }

        private void NotifyAll(string message)
        {
            if (!string.IsNullOrEmpty(Email))
                _emailNotification.Notify(Email, message);

            if (!string.IsNullOrEmpty(PhoneNumber))
                _smsNotification.Notify(PhoneNumber, message);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nAccount Information:");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Account Number: {_accountNumber}");
            Console.WriteLine($"Email: {_email}");
            Console.WriteLine($"Phone Number: {_phoneNumber}");
            Console.WriteLine($"Balance: {_balance}");
        }
    }
}
