using MediatR;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Update
{
    public record UpdateAnimalCommand(
      Guid Id,
      string? animal_name,
      string? specie,
      string? breed,
      decimal? weight,
      int? birth_year

    ) : IRequest<TResult<AnimalResponseDTO>>
    {

    }
}