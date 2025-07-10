using AutoMapper;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update
{
    public class UpdateApointmentHandler : UpdateHandler<IApointmentService, UpdateApointmentCommand, ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
        public UpdateApointmentHandler(IUnitOfWork unitOfWork, IApointmentService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}