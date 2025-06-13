using MediatR;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Delete
{
    public record DeleteVeterinarianCommand(Guid Id) : IRequest<TResult<VeterinarianResponseDTO>>
    {
    }
}