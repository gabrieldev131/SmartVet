using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Create;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Delete;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetAll;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetById;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Update;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Recepcionist")]
    [ApiController]
    public class RecepcionistController : BaseCrudController
        <GetAllRecepcionistCommand,
        GetByIdRecepcionistCommand,
        CreateRecepcionistCommand,
        UpdateRecepcionistCommand,
        DeleteRecepcionistCommand,
        RecepcionistResponseDTO>
    {
        public RecepcionistController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}