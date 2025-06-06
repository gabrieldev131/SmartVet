using AutoMapper;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetById
{
    internal class GetByIdApointmentHandler : GetByIdHandler<IApointmentService, GetByIdApointmentCommand, ApointmentRequestDTO, ApointmentResponseDTO, Apointment>
    {
        public GetByIdApointmentHandler(IApointmentService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}