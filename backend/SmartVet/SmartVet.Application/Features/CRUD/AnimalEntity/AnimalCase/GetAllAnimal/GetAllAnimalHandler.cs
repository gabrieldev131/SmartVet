using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetAll
{
    public class GetAllAnimalHandler : GetAllHandler<IAnimalService, GetAllAnimalCommand, AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
        public GetAllAnimalHandler(IAnimalService service) : base(service)
        {
        }
    }
}