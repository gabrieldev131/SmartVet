using AutoMapper;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.Service
{
    public class RecepcionistService :
        BaseCrudService<
            RecepcionistRequestDTO,
            RecepcionistResponseDTO,
            Recepcionist,
            IRecepcionistRepository>, IRecepcionistService
    {

        public RecepcionistService(IMediator mediator, IMapper mapper, IRecepcionistRepository repository) : base(mediator, mapper, repository) { }

    }
}