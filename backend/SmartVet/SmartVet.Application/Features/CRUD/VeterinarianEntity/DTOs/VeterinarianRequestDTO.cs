using MediatR;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs
{
    public class VeterinarianRequestDTO : IRequest<TResult<VeterinarianResponseDTO>>
    {
        public Guid Id {get; set;}
        public string Crmv { get; set; }
        public string Speciality { get; set; }



    }
}
