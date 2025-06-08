using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.Interface;
using SmartVet.Domain.Entities;
using SmartVet.Application.Base.BaseCase;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetAll
{
    public class GetAllVeterinarianHandler : GetAllHandler<IVeterinarianService, GetAllVeterinarianCommand, VeterinarianRequestDTO, VeterinarianResponseDTO, Veterinarian>
    {
        public GetAllVeterinarianHandler(IVeterinarianService service) : base(service)
        {
        }
    }
}