using Microsoft.EntityFrameworkCore.Storage;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Application.Interfaces.UnitOfWoks;
using OnionArchitecture.Persistence.Context;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IProductRepository ProductRepository { get; }
        public UnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
        {
            _context = context;

            ProductRepository = productRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
        public void Dispose() => _context.Dispose();
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
