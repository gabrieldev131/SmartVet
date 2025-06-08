using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Delete
{
    public record DeleteClientCommand(Guid Id) : IRequest<TResult<ClientResponseDTO>>
    {
    }
}