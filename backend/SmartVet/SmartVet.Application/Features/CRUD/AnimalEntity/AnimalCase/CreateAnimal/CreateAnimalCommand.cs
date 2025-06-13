using MediatR;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Create
{
    public record CreateAnimalCommand(
      string? animal_name,
      string? specie,
      string? breed,
      decimal? weight,
      int? birth_year,
      Guid ClientId,
      Guid ApointmentId

    ) : IRequest<TResult<AnimalResponseDTO>>
    {

    }
}