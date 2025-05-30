using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetAll
{
    public record GetAllServiceCommand() : IRequest<ICollection<ServiceResponseDTO>>
    {

    }
}