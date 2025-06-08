using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetAll
{
    public class GetAllAdminHandler : GetAllHandler<IAdminService, GetAllAdminCommand, AdminRequestDTO, AdminResponseDTO, Admin>
    {
        public GetAllAdminHandler(IAdminService service) : base(service)
        {
        }
    }
}