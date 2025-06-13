using AutoMapper;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Base.BaseCase;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Delete
{
    public class DeleteVeterinarianHandler : DeleteHandler<IVeterinarianService, DeleteVeterinarianCommand, VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
        public DeleteVeterinarianHandler(IUnitOfWork unitOfWork, IVeterinarianService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}