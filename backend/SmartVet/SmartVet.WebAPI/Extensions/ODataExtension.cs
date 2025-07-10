using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
//using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
//using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
//using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
//using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
//using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;


namespace SmartVet.WebApi.Extensions
{
    public static class ODataExtension
    {
        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new();
            //builder.EntitySet<AdminResponseDTO>("admin");
            //builder.EntitySet<RecepcionistResponseDTO>("recepcionist");
            //builder.EntitySet<VeterinarianResponseDTO>("veterinarian");
            //builder.EntitySet<ClientResponseDTO>("client");
            builder.EntitySet<AnimalResponseDTO>("animal");
            //builder.EntitySet<ServiceResponseDTO>("service");
            builder.EntitySet<ApointmentResponseDTO>("apointment");

            return builder.GetEdmModel();
        }

        public static void ODataConfiguration(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                // Add filter exceptions here
            })
            .AddOData(options => options
                .SkipToken()
                .AddRouteComponents("api", GetEdmModel())
                .Select()
                .Filter()
                .OrderBy()
                .SetMaxTop(4)
                .Count()
                .Expand());
        }
    }
}