using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
    }
}
