using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Infrastructure.Repositories.Common;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Create
{
    public class CreateAdminHandler : CreateHandler<IAdminService, CreateAdminCommand, AdminRequestDTO, AdminResponseDTO, Admin>
    {
        public CreateAdminHandler(IUnitOfWork unitOfWork, IAdminService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}