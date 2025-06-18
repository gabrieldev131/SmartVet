using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Base;

namespace SmartVet.Infrastructure.Repositories.Common
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        IQueryable<T> GetById(Guid id);
        IQueryable<T> GetAll();
        public DbSet<T> GetDbSet();
    }
}
