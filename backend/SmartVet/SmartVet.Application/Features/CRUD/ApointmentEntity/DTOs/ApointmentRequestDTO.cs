using MediatR;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs
{
    public class ApointmentRequestDTO : IRequest<TResult<ApointmentResponseDTO>>
    {
        public Guid Id {get; set;}
        public DateTime Scheduled_date { get; set; }
        public int Urgency { get; set; }
        public string? Result_description { get; set; }

        public Guid ApointmentAnimalId { get; set; }


    }
}
