using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetAll
{
    public class GetAllApointmentHandler : GetAllHandler<IApointmentService, GetAllApointmentCommand, ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
        public GetAllApointmentHandler(IApointmentService service) : base(service)
        {
        }
    }
}