using SmartVet.Domain.Base;
using MediatR;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetAll
{
    public record GetAllAdminCommand() : IRequest<ICollection<AdminResponseDTO>>
    {

    }
}