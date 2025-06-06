using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Create;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Delete;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetAll;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetById;
using SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Apointment")]
    [ApiController]
    public class ApointmentController : BaseCrudController
        <GetAllApointmentCommand,
        GetByIdApointmentCommand,
        CreateApointmentCommand,
        UpdateApointmentCommand,
        DeleteApointmentCommand,
        ApointmentResponseDTO>
    {
        public ApointmentController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}