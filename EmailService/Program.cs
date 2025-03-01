using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailService em = new EmailService();

            Notification nf = new Notification(em);

            string to = "hhhh";
            string from = "jjjj";
            string cc = "kkkk";

            nf.NotiFyUser(to, from, cc);
        }
    }
}
