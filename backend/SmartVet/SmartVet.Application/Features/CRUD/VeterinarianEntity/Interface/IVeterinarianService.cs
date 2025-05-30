using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface
{
    public interface IVeterinarianService : IBaseCrudService<VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
    }
}