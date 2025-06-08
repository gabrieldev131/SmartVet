using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.AdminEntity.Service
{
    public class AdminService :
        BaseCrudService<
            AdminRequestDTO,
            AdminResponseDTO,
            Admin,
            IAdminRepository>, IAdminService
    {

        public AdminService(IMediator mediator, IMapper mapper, IAdminRepository repository) : base(mediator, mapper, repository) { }

    }
}