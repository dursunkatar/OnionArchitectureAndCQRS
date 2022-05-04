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

        public void Falan2()
        {
            Console.WriteLine("Email Gönderildi");
        }
    }
}
