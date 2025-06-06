using AutoMapper;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ClientEntity.Service
{
    public class ClientService :
        BaseCrudService<
            ClientRequestDTO,
            ClientResponseDTO,
            Client,
            IClientRepository>, IClientService
    {

        public ClientService(IMediator mediator, IMapper mapper, IClientRepository repository) : base(mediator, mapper, repository) { }

    }
}