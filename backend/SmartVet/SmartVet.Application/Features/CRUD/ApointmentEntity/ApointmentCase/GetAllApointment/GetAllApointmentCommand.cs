using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetAll
{
    public record GetAllApointmentCommand() : IRequest<ICollection<ApointmentResponseDTO>>
    {

    }
}