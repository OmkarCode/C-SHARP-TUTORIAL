using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService;

namespace EmailService
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string from, string subject, string body, string cc= null)
        {
            Console.WriteLine("Sending Email...");
            Console.WriteLine($"To : {to}");
            Console.WriteLine($"From : {from}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Body : {body}");
            if (!string.IsNullOrEmpty(cc)){
                Console.WriteLine($"CC : {cc}");
            }
            Console.WriteLine("Email Sent Successfully...");

        }
    }
}
