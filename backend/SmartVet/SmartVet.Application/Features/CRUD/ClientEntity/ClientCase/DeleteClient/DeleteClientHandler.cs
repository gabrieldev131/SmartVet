using AutoMapper;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Delete
{
    public class DeleteClientHandler : DeleteHandler<IClientService, DeleteClientCommand, ClientRequestDTO, ClientResponseDTO, Client>
    {
        public DeleteClientHandler(IUnitOfWork unitOfWork, IClientService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}