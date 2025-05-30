using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetById
{
    public record GetByIdClientCommand(Guid Id) : IRequest<ClientResponseDTO>
    {
    }
}