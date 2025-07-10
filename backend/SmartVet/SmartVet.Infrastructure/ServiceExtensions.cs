using SmartVet.Infrastructure.Interfaces.Entities;
using SmartVet.Infrastructure.Interfaces.Security;
using SmartVet.Infrastructure.Context;
using SmartVet.Infrastructure.Repositories;
using SmartVet.Infrastructure.Repositories.Entities;
using SmartVet.Infrastructure.Security.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using SmartVet.Infrastructure.Repositories.Common;


namespace SmartVet.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("PostgreSql");
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString, x => x.MigrationsAssembly("SmartVet.Infrastructure")), ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            //services.AddScoped<IGenericUserRepository, GenericUserRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IAdminRepository, AdminRepository>();
            //services.AddScoped<IRecepcionistRepository, RecepcionistRepository>();
            //services.AddScoped<IVeterinarianRepository, VeterinarianRepository>();
            //services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            //services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IApointmentRepository, ApointmentRepository>();

        }
    }
}
