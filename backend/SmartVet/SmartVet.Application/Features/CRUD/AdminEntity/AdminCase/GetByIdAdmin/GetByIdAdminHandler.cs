using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetById
{
    internal class GetByIdAdminHandler : GetByIdHandler<IAdminService, GetByIdAdminCommand, AdminRequestDTO, AdminResponseDTO, Admin>
    {
        public GetByIdAdminHandler(IAdminService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}