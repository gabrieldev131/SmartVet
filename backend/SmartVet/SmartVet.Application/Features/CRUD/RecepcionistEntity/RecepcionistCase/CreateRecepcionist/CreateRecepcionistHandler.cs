using AutoMapper;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs;
using SmartVet.Application.Features.CRUD.RecepcionistEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.RecepcionistCase.Create
{
    public class CreateRecepcionistHandler : CreateHandler<IRecepcionistService, CreateRecepcionistCommand, RecepcionistRequestDTO, RecepcionistResponseDTO, Recepcionist>
    {
        public CreateRecepcionistHandler(IUnitOfWork unitOfWork, IRecepcionistService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}