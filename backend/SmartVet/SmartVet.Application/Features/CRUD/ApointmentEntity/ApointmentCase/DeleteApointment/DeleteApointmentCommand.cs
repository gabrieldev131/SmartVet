using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Delete
{
    public record DeleteApointmentCommand(Guid Id) : IRequest<TResult<ApointmentResponseDTO>>
    {
    }
}