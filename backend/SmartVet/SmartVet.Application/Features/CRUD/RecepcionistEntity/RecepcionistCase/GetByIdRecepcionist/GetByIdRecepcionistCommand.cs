using MediatR;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetById
{
    public record GetByIdRecepcionistCommand(Guid Id) : IRequest<RecepcionistResponseDTO>
    {
    }
}