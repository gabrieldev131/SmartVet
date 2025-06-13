using AutoMapper;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Services.BaseCrudInterface;
using SmartVet.Infrastructure.Interfaces.Entities;

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