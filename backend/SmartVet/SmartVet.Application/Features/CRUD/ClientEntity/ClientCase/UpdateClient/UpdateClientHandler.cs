using AutoMapper;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Update
{
    public class UpdateClientHandler : UpdateHandler<IClientService, UpdateClientCommand, ClientRequestDTO, ClientResponseDTO, Client>
    {
        public UpdateClientHandler(IUnitOfWork unitOfWork, IClientService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}