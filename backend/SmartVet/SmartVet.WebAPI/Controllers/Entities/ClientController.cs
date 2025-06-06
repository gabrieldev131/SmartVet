using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Create;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Delete;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetAll;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetById;
using SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Update;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.WebApi.Controllers.BaseControllers;

namespace SmartVet.WebApi.Controllers.Entities
{
    [Route("api/SmartVet/Client")]
    [ApiController]
    public class ClientController : BaseCrudController
        <GetAllClientCommand,
        GetByIdClientCommand,
        CreateClientCommand,
        UpdateClientCommand,
        DeleteClientCommand,
        ClientResponseDTO>
    {
        public ClientController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}