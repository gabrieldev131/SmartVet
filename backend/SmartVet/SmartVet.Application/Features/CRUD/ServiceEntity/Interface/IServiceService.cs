using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.Interface
{
    public interface IServiceService : IBaseCrudService<ServiceRequestDTO, ServiceResponseDTO, Service>
    {
    }
}