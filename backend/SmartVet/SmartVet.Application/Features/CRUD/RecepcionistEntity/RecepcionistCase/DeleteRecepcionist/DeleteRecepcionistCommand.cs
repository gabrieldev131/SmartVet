using MediatR;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Delete
{
    public record DeleteRecepcionistCommand(Guid Id) : IRequest<TResult<RecepcionistResponseDTO>>
    {
    }
}