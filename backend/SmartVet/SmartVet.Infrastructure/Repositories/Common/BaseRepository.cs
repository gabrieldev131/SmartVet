using System.Linq;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using SmartVet.Domain.Base;
using SmartVet.Domain.Security.Account.Entities;
using SmartVet.Domain.Security.Shared.Entities;
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

        public async Task<T> Create(T baseEntity)
        {
            Context.Add(baseEntity);
            await Context.SaveChangesAsync();
            return baseEntity;
        }

        public async Task<T> Delete(T baseEntity)
        {
            Context.Remove<T>(baseEntity);
            await Context.SaveChangesAsync();

            return baseEntity;
        }

        public async Task<T> Update(T baseEntity)
        {
            Context.Update<T>(baseEntity);
            await Context.SaveChangesAsync();

            return baseEntity;
        }

        public IQueryable<T> GetById(Guid id)
        {

            return Context.Set<T>().AsNoTracking().Where(e => e.Id == id);
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
