using AutoMapper;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.GetById
{
    internal class GetByIdRecepcionistHandler : GetByIdHandler<IRecepcionistService, GetByIdRecepcionistCommand, RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
        public GetByIdRecepcionistHandler(IRecepcionistService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}