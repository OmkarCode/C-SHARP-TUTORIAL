using System;

namespace InterfaceApp
{
    interface IEmailService
    {
        void SendEmail(string to, string from, string sub, string body, string cc = null);
    }

    class EmailService : IEmailService
    {
        public void SendEmail(string to, string from, string sub, string body, string cc = null)
        {
            Console.WriteLine("Sending Email....  ");
            Console.WriteLine($"To : {to}");
            Console.WriteLine($"From : {from}");
            Console.WriteLine($"Subject : {sub}");
            Console.WriteLine($"Body : {body}");
            if (!string.IsNullOrEmpty(cc))
            {
                Console.WriteLine($"CC : {cc}");
            }
            Console.WriteLine("Email Sent Successfully...");
        }
    }

    public class Program
    {
        static void Main(string[] args) 
        { 
            EmailService emailService = new EmailService();
            string to = "Omkar";
            string from = "Jay";
            string sub = "Hello";
            string body = "Go";
            string cc = "TATA";

            emailService.SendEmail(to, from, sub, body, cc);
        }
    }

    
}
