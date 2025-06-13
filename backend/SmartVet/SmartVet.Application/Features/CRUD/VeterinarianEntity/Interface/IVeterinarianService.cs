using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface
{
    public interface IVeterinarianService : IBaseCrudService<VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
    }
}