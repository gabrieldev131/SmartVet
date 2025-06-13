using AutoMapper;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Update
{
    public class UpdateRecepcionistHandler : UpdateHandler<IRecepcionistService, UpdateRecepcionistCommand, RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
        public UpdateRecepcionistHandler(IUnitOfWork unitOfWork, IRecepcionistService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}