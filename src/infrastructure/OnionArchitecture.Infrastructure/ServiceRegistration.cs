using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces;

namespace OnionArchitecture.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection collection)
        {
            collection.AddTransient<IEmailService, EmailService>();
        }
    }
}
