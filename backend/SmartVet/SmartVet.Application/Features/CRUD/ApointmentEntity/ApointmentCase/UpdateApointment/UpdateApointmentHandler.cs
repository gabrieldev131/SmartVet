using AutoMapper;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Update
{
    public class UpdateApointmentHandler : UpdateHandler<IApointmentService, UpdateApointmentCommand, ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
        public UpdateApointmentHandler(IUnitOfWork unitOfWork, IApointmentService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}