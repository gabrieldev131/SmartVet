using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AdminEntity.Interface
{
    public interface IAdminService : IBaseCrudService<AdminRequestDTO, AdminResponseDTO, Admin>
    {
    }
}