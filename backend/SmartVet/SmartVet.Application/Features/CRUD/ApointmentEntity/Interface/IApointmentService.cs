using SmartVet.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.Interface
{
    public interface IApointmentService : IBaseCrudService<ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
    }
}