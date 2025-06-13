using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface
{
    public interface IRecepcionistService : IBaseCrudService<RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
    }
}