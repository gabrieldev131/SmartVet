using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Features.CRUD.ClientEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetAll
{
    public class GetAllClientHandler : GetAllHandler<IClientService, GetAllClientCommand, ClientRequestDTO, ClientResponseDTO, Client>
    {
        public GetAllClientHandler(IClientService service) : base(service)
        {
        }
    }
}