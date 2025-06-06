using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetAll
{
    public class GetAllRecepcionistHandler : GetAllHandler<IRecepcionistService, GetAllRecepcionistCommand, RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
        public GetAllRecepcionistHandler(IRecepcionistService service) : base(service)
        {
        }
    }
}