using AutoMapper;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Delete
{
    public class DeleteApointmentHandler : DeleteHandler<IApointmentService, DeleteApointmentCommand, ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
        public DeleteApointmentHandler(IUnitOfWork unitOfWork, IApointmentService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}