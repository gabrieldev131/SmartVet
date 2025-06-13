using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Create
{
    public record CreateApointmentCommand(
      DateTime? scheduled_date,
      int? urgency,
      string? result_description,
      Guid AnimalId,
      Guid VeterinarianId,
      Guid ServiceId

    ) : IRequest<TResult<ApointmentResponseDTO>>
    {

    }
}