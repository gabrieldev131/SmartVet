using SmartVet.Domain.Entities;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.Interface
{
    public interface IApointmentService : IBaseCrudService<ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
    }
}