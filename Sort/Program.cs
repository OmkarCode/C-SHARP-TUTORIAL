using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IEmailService
    {
        void SendEmail(string to, string from, string subject, string body, string cc = null);
    }

    public class EmailService : IEmailService{
        public void SendEmail(string to, string from, string subject, string body, string cc = null)
    {
        Console.WriteLine("Send Email...");
            Console.WriteLine($"To : {to}");
            Console.WriteLine($"From : {from}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Body : {body}");
            if (!string.IsNullOrEmpty(cc)){
                Console.WriteLine($"CC : {cc}");
            }
            Console.WriteLine("Mail send....");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail("Omkar", "Om", "ok", "go");
        }
    }
}
