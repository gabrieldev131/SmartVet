using AutoMapper;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Services.BaseCrudInterface;
using SmartVet.Infrastructure.Interfaces.Entities;

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