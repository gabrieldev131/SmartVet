using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Create;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Delete;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetAll;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetById;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Update;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Veterinarian")]
    [ApiController]
    public class VeterinarianController : BaseCrudController
        <GetAllVeterinarianCommand,
        GetByIdVeterinarianCommand,
        CreateVeterinarianCommand,
        UpdateVeterinarianCommand,
        DeleteVeterinarianCommand,
        VeterinarianResponseDTO>
    {
        public VeterinarianController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}