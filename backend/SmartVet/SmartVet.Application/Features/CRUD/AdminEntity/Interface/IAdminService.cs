using SmartVet.Domain.Entities;
using SmartVet.Application.Interfaces.BaseCrudInterface;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AdminEntity.Interface
{
    public interface IAdminService : IBaseCrudService<AdminRequestDTO, AdminResponseDTO, Admin>
    {
    }
}