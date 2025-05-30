using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface
{
    public interface IRecepcionistService : IBaseCrudService<RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
    }
}