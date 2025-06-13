using SmartVet.Domain.Entities;
using SmartVet.Application.Interfaces.BaseCrudInterface;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.Interface
{
    public interface IServiceService : IBaseCrudService<ServiceRequestDTO, ServiceResponseDTO, Service>
    {
    }
}