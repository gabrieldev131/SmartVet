using AutoMapper;
using SmartVet.Application.Features.CRUD.AdminEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Infrastructure.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Services.BaseCrudInterface;
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