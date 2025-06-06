using AutoMapper;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetById
{
    internal class GetByIdServiceHandler : GetByIdHandler<IServiceService, GetByIdServiceCommand, ServiceRequestDTO, ServiceResponseDTO, Service>
    {
        public GetByIdServiceHandler(IServiceService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}