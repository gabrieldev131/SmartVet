using AutoMapper;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetById
{
    internal class GetByIdAnimalHandler : GetByIdHandler<IAnimalService, GetByIdAnimalCommand, AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
        public GetByIdAnimalHandler(IAnimalService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}