using AutoMapper;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Delete
{
    public class DeleteAnimalHandler : DeleteHandler<IAnimalService, DeleteAnimalCommand, AnimalRequestDTO, AnimalResponseDTO, Animal>
    {
        public DeleteAnimalHandler(IUnitOfWork unitOfWork, IAnimalService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}