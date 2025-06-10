using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Base;
using SmartVet.Domain.Security.Account.Entities;
using SmartVet.Infrastructure.Context;

namespace SmartVet.Infrastructure.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private AppDbContext Context { get; set; }


        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }

        public Task Create(T baseEntity)
        {
            Context.Add<T>(baseEntity);
            Context.SaveChanges();

            return Task.FromResult(baseEntity);
        }

        public Task Delete(T baseEntity)
        {
            Context.Remove<T>(baseEntity);
            Context.SaveChanges();

            return Task.FromResult(baseEntity);
        }

        public Task Update(T baseEntity)
        {
            Context.Update<T>(baseEntity);
            Context.SaveChanges();

            return Task.FromResult(baseEntity);
        }

        public IQueryable<T> GetById(Guid id)
        {

            return Context.Set<T>().Where(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public DbSet<T> GetDbSet()
        {
            return Context.Set<T>() ;
        }
    }
}
