using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Create;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Delete;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetAll;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetById;
using SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Update;
using SmartVet.Application.Features.CRUD.AdminEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Admin")]
    [ApiController]
    public class AdminController : BaseCrudController
        <GetAllAdminCommand,
        GetByIdAdminCommand,
        CreateAdminCommand,
        UpdateAdminCommand,
        DeleteAdminCommand,
        AdminResponseDTO>
    {
        public AdminController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}