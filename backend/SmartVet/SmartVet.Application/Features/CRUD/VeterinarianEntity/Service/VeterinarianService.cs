using AutoMapper;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.Service
{
    public class VeterinarianService :
        BaseCrudService<
            VeterinarianRequestDTO,
            VeterinarianResponseDTO,
            Veterinarian,
            IVeterinarianRepository>, IVeterinarianService
    {

        public VeterinarianService(IMediator mediator, IMapper mapper, IVeterinarianRepository repository) : base(mediator, mapper, repository) { }

    }
}