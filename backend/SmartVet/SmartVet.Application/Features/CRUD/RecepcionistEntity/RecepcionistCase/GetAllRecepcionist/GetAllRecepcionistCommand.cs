using MediatR;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetAll
{
    public record GetAllRecepcionistCommand() : IRequest<ICollection<RecepcionistResponseDTO>>
    {

    }
}