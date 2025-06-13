using MediatR;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetAll
{
    public record GetAllClientCommand() : IRequest<ICollection<ClientResponseDTO>>
    {

    }
}