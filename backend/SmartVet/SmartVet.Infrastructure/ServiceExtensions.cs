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
using Microsoft.AspNetCore.Identity; // Para Identity
using SmartVet.Domain.Security.Account.Entities; // Sua classe ApplicationUser e IdentityRole
using SmartVet.Domain.Security.Authentication; // Sua interface IAuthenticationService
using SmartVet.Infrastructure.Security.Authentication; // Sua implementa��o AuthenticationService

namespace SmartVet.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("PostgreSql");
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(
                opt => opt.UseNpgsql(connectionString, 
                x => x.MigrationsAssembly("SmartVet.Infrastructure")), 
                ServiceLifetime.Scoped);

            // --- IN�CIO DAS ADI��ES NECESS�RIAS ---

            // 1. Configura��o do ASP.NET Core Identity
            // Certifique-se que ApplicationUser � sua classe de usu�rio
            // E que AppDbContext � o DbContext que herda de IdentityDbContext<ApplicationUser>
            services.AddIdentity<User, Role>(options =>
            {
                // Opcional: Configure as op��es de senha, lockout, etc.
                // Adapte conforme as suas pol�ticas de seguran�a
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = true; // Garante que e-mails s�o �nicos
            })
            .AddEntityFrameworkStores<AppDbContext>() // Conecta o Identity ao seu AppDbContext
            .AddDefaultTokenProviders(); // Habilita funcionalidades como reset de senha, confirma��o de email, etc.

            // 2. Registrar a implementa��o do seu servi�o de autentica��o
            // A interface IAuthenticationService (do seu Domain) mapeada para sua implementa��o AuthenticationService (do Infrastructure)
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            // --- FIM DAS ADI��ES NECESS�RIAS ---


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IRoleRepository, RoleRepository>();
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