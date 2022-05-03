using Microsoft.EntityFrameworkCore.Storage;
using OnionArchitecture.Application.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.UnitOfWoks
{
    public interface IUnitOfWork : IDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<int> SaveChangesAsync();
        IProductRepository ProductRepository { get; }
    }
}
