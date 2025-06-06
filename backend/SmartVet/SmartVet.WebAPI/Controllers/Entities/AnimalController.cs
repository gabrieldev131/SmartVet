using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Create;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Delete;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetAll;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetById;
using SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Update;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Animal")]
    [ApiController]
    public class AnimalController : BaseCrudController
        <GetAllAnimalCommand,
        GetByIdAnimalCommand,
        CreateAnimalCommand,
        UpdateAnimalCommand,
        DeleteAnimalCommand,
        AnimalResponseDTO>
    {
        public AnimalController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}