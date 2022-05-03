using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Context;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
