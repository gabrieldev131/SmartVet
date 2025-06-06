using AutoMapper;
using SmartVet.Application.Features.CRUD.ServiceEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.Service
{
    public class ServiceService :
        BaseCrudService<
            ServiceRequestDTO,
            ServiceResponseDTO,
            Service,
            IServiceRepository>, IServiceService
    {

        public ServiceService(IMediator mediator, IMapper mapper, IServiceRepository repository) : base(mediator, mapper, repository) { }

    }
}