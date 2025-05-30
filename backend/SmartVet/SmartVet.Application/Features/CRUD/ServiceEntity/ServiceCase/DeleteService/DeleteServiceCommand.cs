using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Delete
{
    public record DeleteServiceCommand(Guid Id) : IRequest<TResult<ServiceResponseDTO>>
    {
    }
}