using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.Interface
{
    public interface IAnimalService : IBaseCrudService<AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
    }
}