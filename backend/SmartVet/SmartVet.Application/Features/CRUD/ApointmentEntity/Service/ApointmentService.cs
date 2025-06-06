using AutoMapper;
using SmartVet.Application.Features.CRUD.ApointmentEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.Service
{
    public class ApointmentService :
        BaseCrudService<
            ApointmentRequestDTO,
            ApointmentResponseDTO,
            Apointment,
            IApointmentRepository>, IApointmentService
    {

        public ApointmentService(IMediator mediator, IMapper mapper, IApointmentRepository repository) : base(mediator, mapper, repository) { }

    }
}