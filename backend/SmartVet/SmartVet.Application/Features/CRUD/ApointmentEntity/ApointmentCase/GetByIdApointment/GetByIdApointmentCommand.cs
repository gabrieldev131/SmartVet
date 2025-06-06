using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetById
{
    public record GetByIdApointmentCommand(Guid Id) : IRequest<ApointmentResponseDTO>
    {
    }
}