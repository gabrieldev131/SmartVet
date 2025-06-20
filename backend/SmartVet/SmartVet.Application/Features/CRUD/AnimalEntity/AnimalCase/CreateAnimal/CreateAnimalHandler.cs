using AutoMapper;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Create
{
    public class CreateAnimalHandler : CreateHandler<IAnimalService, CreateAnimalCommand, AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
        public CreateAnimalHandler(IUnitOfWork unitOfWork, IAnimalService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}