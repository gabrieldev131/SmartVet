using ConectaFapes.Common.Domain;
using MediatR;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Domain.Enums;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Create
{
    public record CreateAdminCommand(

    ) : IRequest<TResult<AdminResponseDTO>>
    {

    }
}