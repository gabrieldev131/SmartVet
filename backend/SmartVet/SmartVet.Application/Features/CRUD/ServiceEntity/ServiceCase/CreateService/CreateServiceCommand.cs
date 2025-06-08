using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Create
{
    public record CreateServiceCommand(
      string? service_name,
      string? service_description,
      decimal? price,
      Guid ApointmentId

    ) : IRequest<TResult<ServiceResponseDTO>>
    {

    }
}