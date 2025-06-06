using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetAll
{
    public record GetAllVeterinarianCommand() : IRequest<ICollection<VeterinarianResponseDTO>>
    {

    }
}