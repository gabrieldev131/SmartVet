using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Delete
{
    public class DeleteAdminHandler : DeleteHandler<IAdminService, DeleteAdminCommand, AdminRequestDTO, AdminResponseDTO, Admin>
    {
        public DeleteAdminHandler(IUnitOfWork unitOfWork, IAdminService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}