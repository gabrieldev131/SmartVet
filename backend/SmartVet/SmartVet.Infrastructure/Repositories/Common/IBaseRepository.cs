using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Base;

namespace SmartVet.Infrastructure.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        IQueryable<T> GetById(Guid id);
        IQueryable<T> GetAll();
        public DbSet<T> GetDbSet();
    }
}
