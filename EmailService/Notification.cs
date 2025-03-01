using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class Notification
    {
        private readonly IEmailService _emailService;

        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void NotiFyUser(string to, string from, string cc = null)
        {
            string subject = "Good Morning ...";
            string body = "ABABABABBABABABABABABABABAB";

            _emailService.SendEmail(to, from, subject, body, cc);
        }
    }
}
