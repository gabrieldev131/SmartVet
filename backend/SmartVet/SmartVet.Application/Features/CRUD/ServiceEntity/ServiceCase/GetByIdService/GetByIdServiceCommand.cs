using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetById
{
    public record GetByIdServiceCommand(Guid Id) : IRequest<ServiceResponseDTO>
    {
    }
}