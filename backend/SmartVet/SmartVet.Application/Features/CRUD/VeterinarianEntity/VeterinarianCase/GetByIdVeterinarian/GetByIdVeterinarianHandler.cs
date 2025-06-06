using AutoMapper;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetById
{
    internal class GetByIdVeterinarianHandler : GetByIdHandler<IVeterinarianService, GetByIdVeterinarianCommand, VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
        public GetByIdVeterinarianHandler(IVeterinarianService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}