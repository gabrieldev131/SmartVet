using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Update
{
    public record UpdateAdminCommand(
      Guid Id,

    ) : IRequest<TResult<AdminResponseDTO>>
    {

    }
}