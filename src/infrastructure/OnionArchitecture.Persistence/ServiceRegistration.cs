using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Application.Interfaces.UnitOfWoks;
using OnionArchitecture.Persistence.Context;
using OnionArchitecture.Persistence.Repositories;
using OnionArchitecture.Persistence.UnitOfWorks;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SQLServer")), ServiceLifetime.Scoped);
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
