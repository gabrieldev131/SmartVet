using MediatR;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Create
{
    public record CreateClientCommand(
      String? identification,
      string? phone_number,
      string? address,
      Guid AnimalId

    ) : IRequest<TResult<ClientResponseDTO>>
    {

    }
}