using MediatR;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetById
{
    public record GetByIdAnimalCommand(Guid Id) : IRequest<AnimalResponseDTO>
    {
    }
}