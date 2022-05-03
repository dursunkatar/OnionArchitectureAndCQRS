using OnionArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<T> AddAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(Guid Id);
        T Update(T entity);
    }
}
