using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Update
{
    public record UpdateServiceCommand(
      Guid Id,
      string? service_name,
      string? service_description,
      decimal? price,
      Guid ApointmentId

    ) : IRequest<TResult<ServiceResponseDTO>>
    {

    }
}