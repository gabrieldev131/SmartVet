using SmartVet.Domain.Base;
using MediatR;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Delete
{
    public record DeleteAdminCommand(Guid Id) : IRequest<TResult<AdminResponseDTO>>
    {
    }
}