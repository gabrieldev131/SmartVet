using AutoMapper;
using SmartVet.Application.Features.CRUD.AnimalEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;

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