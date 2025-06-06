using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetAll
{
    public record GetAllAnimalCommand() : IRequest<ICollection<AnimalResponseDTO>>
    {

    }
}