using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Update
{
    public class UpdateAdminHandler : UpdateHandler<IAdminService, UpdateAdminCommand, AdminRequestDTO, AdminResponseDTO, Admin>
    {
        public UpdateAdminHandler(IUnitOfWork unitOfWork, IAdminService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}