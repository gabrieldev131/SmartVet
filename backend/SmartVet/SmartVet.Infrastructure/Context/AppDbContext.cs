using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Security.Account.Entities;

namespace SmartVet.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<User, Role, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; } = null!;
        //public DbSet<GenericUser> GenericUsers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        //public DbSet<Recepcionist> Recepcionists { get; set; }
        //public DbSet<Veterinarian> Veterinarians { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<Animal> Animals { get; set; }
        //public DbSet<Service> Services { get; set; }
        public DbSet<Apointment> Apointments { get; set; }

    }
}
