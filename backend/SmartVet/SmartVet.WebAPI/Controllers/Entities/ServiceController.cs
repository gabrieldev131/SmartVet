using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Create;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Delete;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetAll;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetById;
using SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Update;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Service")]
    [ApiController]
    public class ServiceController : BaseCrudController
        <GetAllServiceCommand,
        GetByIdServiceCommand,
        CreateServiceCommand,
        UpdateServiceCommand,
        DeleteServiceCommand,
        ServiceResponseDTO>
    {
        public ServiceController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}