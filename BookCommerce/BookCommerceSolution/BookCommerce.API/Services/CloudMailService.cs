﻿using BookCommerce.API.Interfaces;
using System.Diagnostics;

namespace BookCommerce.API.Services
{
    public class CloudMailService : IMailService
    {
        // This is just a demo mail service.
        private string _mailTo = Startup.Configuration["mailSettings:mailToAddress"];
        private string _mailFrom = Startup.Configuration["mailSettings:mailFromAddress"];

        public void Send(string subject, string message)
        {
            // Send mail - output to debug window.
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with CloudMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
