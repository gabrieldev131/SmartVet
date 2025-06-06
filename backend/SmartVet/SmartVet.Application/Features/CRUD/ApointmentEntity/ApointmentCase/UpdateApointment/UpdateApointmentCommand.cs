using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update
{
    public record UpdateApointmentCommand(
      Guid Id,
      datetime? scheduled_date,
      int? urgency,
      string? result_description,
      Guid AnimalId,
      Guid VeterinarianId,
      Guid ServiceId

    ) : IRequest<TResult<ApointmentResponseDTO>>
    {

    }
}