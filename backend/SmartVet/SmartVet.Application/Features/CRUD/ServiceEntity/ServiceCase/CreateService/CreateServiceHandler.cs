using AutoMapper;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Create
{
    public class CreateServiceHandler : CreateHandler<IServiceService, CreateServiceCommand, ServiceRequestDTO, ServiceResponseDTO, Service>
    {
        public CreateServiceHandler(IUnitOfWork unitOfWork, IServiceService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}