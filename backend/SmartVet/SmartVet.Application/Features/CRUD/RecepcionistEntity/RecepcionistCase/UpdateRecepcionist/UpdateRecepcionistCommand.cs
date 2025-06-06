using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Update
{
    public record UpdateRecepcionistCommand(
      Guid Id,

    ) : IRequest<TResult<RecepcionistResponseDTO>>
    {

    }
}