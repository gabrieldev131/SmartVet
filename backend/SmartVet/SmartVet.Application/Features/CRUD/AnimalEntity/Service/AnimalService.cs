using AutoMapper;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Infrastructure.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Services.BaseCrudInterface;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.Service
{
    public class AnimalService :
        BaseCrudService<
            AnimalRequestDTO,
            AnimalResponseDTO,
            Animal,
            IAnimalRepository>, IAnimalService
    {

        public AnimalService(IMediator mediator, IMapper mapper, IAnimalRepository repository) : base(mediator, mapper, repository) { }

    }
}