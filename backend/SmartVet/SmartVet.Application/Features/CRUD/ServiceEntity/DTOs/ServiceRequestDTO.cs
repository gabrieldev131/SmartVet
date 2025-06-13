using MediatR;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.DTOs
{
    public class ServiceRequestDTO : IRequest<TResult<ServiceResponseDTO>>
    {
        public Guid Id {get; set;}
        public string Service_name { get; set; }
        public string Service_description { get; set; }
        public decimal Price { get; set; }



    }
}
