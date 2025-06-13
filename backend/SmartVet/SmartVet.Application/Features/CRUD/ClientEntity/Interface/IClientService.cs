using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Features.CRUD.ClientEntity.Interface
{
    public interface IClientService : IBaseCrudService<ClientRequestDTO, ClientResponseDTO, Client>
    {
    }
}