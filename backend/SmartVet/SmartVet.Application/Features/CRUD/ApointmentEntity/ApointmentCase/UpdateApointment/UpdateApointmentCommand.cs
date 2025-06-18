using MediatR;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update
{
    public record UpdateApointmentCommand(
      Guid Id,
      DateTime? scheduled_date,
      int? urgency,
      string? result_description,
      Guid AnimalId

    ) : IRequest<TResult<ApointmentResponseDTO>>
    {

    }
}