using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
//using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
//using SmartVet.Application.Features.CRUD.AdminEntity.Service;
//using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
//using SmartVet.Application.Features.CRUD.RecepcionistEntity.Service;
//using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
//using SmartVet.Application.Features.CRUD.VeterinarianEntity.Service;
//using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
//using SmartVet.Application.Features.CRUD.ClientEntity.Service;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Application.Features.CRUD.AnimalEntity.Service;
//using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
//using SmartVet.Application.Features.CRUD.ServiceEntity.Service;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Service;
//using SmartVet.Application.Features.generateReportCase.apointmentReport.Interfaces;
//using SmartVet.Application.Features.generateReportCase.apointmentReport.Services;
//using SmartVet.Application.Features.generateReportCase.userReport.Interfaces;
//using SmartVet.Application.Features.generateReportCase.userReport.Services;


using SmartVet.Application.Shared.Behavior;
using System.Reflection;

namespace SmartVet.Application.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            //services.AddScoped<IAdminService, AdminService>();
            //services.AddScoped<IRecepcionistService, RecepcionistService>();
            //services.AddScoped<IVeterinarianService, VeterinarianService>();
            //services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IAnimalService, AnimalService>();
            //services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IApointmentService, ApointmentService>();
            //services.AddScoped<IapointmentReportService, apointmentReportService>();
            //services.AddScoped<IuserReportService, userReportService>();

        }
    }
}