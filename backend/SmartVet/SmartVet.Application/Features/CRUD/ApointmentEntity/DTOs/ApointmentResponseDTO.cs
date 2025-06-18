using SmartVet.Application.Dto;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;
//using SmartVet.Application.Features.CRUD.VeterinarianEntity.DTOs;
//using SmartVet.Application.Features.CRUD.ServiceEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs
{
    public class ApointmentResponseDTO : BaseDto
    {
        public DateTime Scheduled_date { get; set; }
        public int Urgency { get; set; }
        public string? Result_description { get; set; }
        public virtual AnimalResponseDTO? Animal { get; set; }
        public Guid ApointmentAnimalId { get; set; }
    }
}
