using Microsoft.Extensions.DependencyInjection;
using SmartVet.Application.Security.Authentication;

namespace SmartVet.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<LoginUserUseCase>();
        }
    }
}
