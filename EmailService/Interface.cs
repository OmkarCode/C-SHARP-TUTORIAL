﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailService
    {
        void SendEmail(string to, string from, string subject, string body, string cc = null);
    }
}
