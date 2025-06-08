using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Delete
{
    public record DeleteAnimalCommand(Guid Id) : IRequest<TResult<AnimalResponseDTO>>
    {
    }
}