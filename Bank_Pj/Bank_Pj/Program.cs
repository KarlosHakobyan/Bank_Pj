using System;
using Bank_Pj.Services;

namespace BankAccountNotification
{

    class Program
    {
        static void Main(string[] args)
        {
            IMessageService emailService = new MailService();
            IMessageService smsService = new SmsService();

            Notification emailNotification = new Notification(emailService);
            Notification smsNotification = new Notification(smsService);

            BankAccount account = new BankAccount(emailNotification, smsNotification)
            {
                Email = "Karlos@gmail.com",
                PhoneNumber = "1234567890",
                Name = "John Doe",
                AccountNumber = "1234567890",
                Balance = 1000m
            };

            while (true)
            {
                account.DisplayInfo();

                Console.WriteLine("\nWhat would you like to change?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Account Number");
                Console.WriteLine("3. Email");
                Console.WriteLine("4. Phone Number");
                Console.WriteLine("5. Balance");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new name: ");
                        account.Name = Console.ReadLine();
                        break;

                    case "2":
                        Console.Write("Enter new account number: ");
                        account.AccountNumber = Console.ReadLine();
                        break;

                    case "3":
                        Console.Write("Enter new email: ");
                        account.Email = Console.ReadLine();
                        break;

                    case "4":
                        Console.Write("Enter new phone number: ");
                        account.PhoneNumber = Console.ReadLine();
                        break;

                    case "5":
                        Console.Write("Enter new balance: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newBalance))
                        {
                            account.Balance = newBalance;
                        }
                        else
                        {
                            Console.WriteLine("Invalid balance. Please enter a valid number.");
                        }
                        break;

                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
