using AutoMapper;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetById
{
    internal class GetByIdClientHandler : GetByIdHandler<IClientService, GetByIdClientCommand, ClientRequestDTO, ClientResponseDTO, Client>
    {
        public GetByIdClientHandler(IClientService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}