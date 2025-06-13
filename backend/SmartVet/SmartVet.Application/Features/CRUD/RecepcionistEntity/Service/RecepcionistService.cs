using AutoMapper;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Services.BaseCrudInterface;
using SmartVet.Infrastructure.Interfaces.Entities;

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