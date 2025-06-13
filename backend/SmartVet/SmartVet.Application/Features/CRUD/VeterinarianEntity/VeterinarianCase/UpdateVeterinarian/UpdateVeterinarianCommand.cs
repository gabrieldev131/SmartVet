using MediatR;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Update
{
    public record UpdateVeterinarianCommand(
      Guid Id,
      string? crmv,
      string? speciality,
      Guid ApointmentId

    ) : IRequest<TResult<VeterinarianResponseDTO>>
    {

    }
}