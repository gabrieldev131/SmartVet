using AutoMapper;
using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Delete
{
    public class DeleteServiceHandler : DeleteHandler<IServiceService, DeleteServiceCommand, ServiceRequestDTO, ServiceResponseDTO, Service>
    {
        public DeleteServiceHandler(IUnitOfWork unitOfWork, IServiceService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}