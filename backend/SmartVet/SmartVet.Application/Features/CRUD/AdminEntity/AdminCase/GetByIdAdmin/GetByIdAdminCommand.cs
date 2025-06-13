using SmartVet.Domain.Base;
using MediatR;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetById
{
    public record GetByIdAdminCommand(Guid Id) : IRequest<AdminResponseDTO>
    {
    }
}