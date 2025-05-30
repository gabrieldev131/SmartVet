using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ClientEntity.Interface
{
    public interface IClientService : IBaseCrudService<ClientRequestDTO, ClientResponseDTO, Client>
    {
    }
}