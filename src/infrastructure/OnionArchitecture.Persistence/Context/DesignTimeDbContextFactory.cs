using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OnionArchitecture.Persistence.Context
{
    public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);
        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> builder = new DbContextOptionsBuilder<TContext>();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProductExample.WebAPI"))
                .AddJsonFile("appsettings.json")
                .Build();
            builder.UseSqlServer(configuration.GetConnectionString("SQLServer"));

            //builder.UseSqlServer(ConnectionStrings.SQLServer);

            return CreateNewInstance(builder.Options);
        }
    }
}
