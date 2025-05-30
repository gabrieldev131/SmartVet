using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetAll
{
    public class GetAllServiceHandler : GetAllHandler<IServiceService, GetAllServiceCommand, ServiceRequestDTO, ServiceResponseDTO, Service>
    {
        public GetAllServiceHandler(IServiceService service) : base(service)
        {
        }
    }
}