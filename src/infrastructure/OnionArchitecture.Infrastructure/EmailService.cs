using OnionArchitecture.Application.Interfaces;
using System;

namespace OnionArchitecture.Infrastructure
{
    public class EmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Email Gönderildi");
        }
    }
}
