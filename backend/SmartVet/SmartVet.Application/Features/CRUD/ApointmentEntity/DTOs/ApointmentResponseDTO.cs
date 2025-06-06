using ConectaFapes.Common.Application.DTO;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs
{
    public class ApointmentResponseDTO : BaseDto
    {
        public datetime Scheduled_date { get; set; }
        public int Urgency { get; set; }
        public string Result_description { get; set; }
        public virtual AnimalResponseDTO Animal { get; set; }
        public Guid ApointmentAnimalId { get; set; }
        public virtual VeterinarianResponseDTO Veterinarian { get; set; }
        public Guid ApointmentVeterinarianId { get; set; }
        public virtual ICollection<ServiceResponseDTO>? Services { get; set;}


    }
}
