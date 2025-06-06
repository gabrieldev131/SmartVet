using ConectaFapes.Common.Application.DTO;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs
{
    public class VeterinarianResponseDTO : BaseDto
    {
        public string Crmv { get; set; }
        public string Speciality { get; set; }



    }
}
