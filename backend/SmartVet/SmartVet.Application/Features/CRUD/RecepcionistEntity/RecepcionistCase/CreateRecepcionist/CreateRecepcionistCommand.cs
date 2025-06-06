using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Create
{
    public record CreateRecepcionistCommand(

    ) : IRequest<TResult<RecepcionistResponseDTO>>
    {

    }
}