using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetById
{
    public record GetByIdVeterinarianCommand(Guid Id) : IRequest<VeterinarianResponseDTO>
    {
    }
}