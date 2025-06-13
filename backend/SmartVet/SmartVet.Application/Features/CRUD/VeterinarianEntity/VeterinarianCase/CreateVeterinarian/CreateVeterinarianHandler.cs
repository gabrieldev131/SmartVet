using AutoMapper;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Create
{
    public class CreateVeterinarianHandler : CreateHandler<IVeterinarianService, CreateVeterinarianCommand, VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
        public CreateVeterinarianHandler(IUnitOfWork unitOfWork, IVeterinarianService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}