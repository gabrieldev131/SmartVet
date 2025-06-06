using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Update
{
    public record UpdateClientCommand(
      Guid Id,
      String? identification,
      string? phone_number,
      string? address,
      Guid AnimalId

    ) : IRequest<TResult<ClientResponseDTO>>
    {

    }
}