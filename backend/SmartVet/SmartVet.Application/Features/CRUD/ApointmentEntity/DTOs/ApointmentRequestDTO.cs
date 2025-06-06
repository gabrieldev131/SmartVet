using MediatR;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs
{
    public class ApointmentRequestDTO : IRequest<TResult<ApointmentResponseDTO>>
    {
        public Guid Id {get; set;}
        public datetime Scheduled_date { get; set; }
        public int Urgency { get; set; }
        public string Result_description { get; set; }

        public Guid ApointmentAnimalId { get; set; }
        public Guid ApointmentVeterinarianId { get; set; }


    }
}
