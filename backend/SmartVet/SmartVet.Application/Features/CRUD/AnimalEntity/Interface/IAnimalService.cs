using SmartVet.Domain.Entities;
using SmartVet.Application.Interfaces.BaseCrudInterface;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.Interface
{
    public interface IAnimalService : IBaseCrudService<AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
    }
}