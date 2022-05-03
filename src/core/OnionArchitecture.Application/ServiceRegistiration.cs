using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OnionArchitecture.Application
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
