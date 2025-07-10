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
using SmartVet.Infrastructure.Security.Authentication; // Sua implementação AuthenticationService

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

            // --- INÍCIO DAS ADIÇÕES NECESSÁRIAS ---

            // 1. Configuração do ASP.NET Core Identity
            // Certifique-se que ApplicationUser é sua classe de usuário
            // E que AppDbContext é o DbContext que herda de IdentityDbContext<ApplicationUser>
            services.AddIdentity<User, Role>(options =>
            {
                // Opcional: Configure as opções de senha, lockout, etc.
                // Adapte conforme as suas políticas de segurança
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = true; // Garante que e-mails são únicos
            })
            .AddEntityFrameworkStores<AppDbContext>() // Conecta o Identity ao seu AppDbContext
            .AddDefaultTokenProviders(); // Habilita funcionalidades como reset de senha, confirmação de email, etc.

            // 2. Registrar a implementação do seu serviço de autenticação
            // A interface IAuthenticationService (do seu Domain) mapeada para sua implementação AuthenticationService (do Infrastructure)
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            // --- FIM DAS ADIÇÕES NECESSÁRIAS ---


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