using ConectaFapes.Common.Application.DTO;
using SmartVet.Application.Features.CRUD.ClientEntity.DTOs;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.AnimalEntity.DTOs
{
    public class AnimalResponseDTO : BaseDto
    {
        public string Animal_name { get; set; }
        public string Specie { get; set; }
        public string Breed { get; set; }
        public decimal Weight { get; set; }
        public int Birth_year { get; set; }
        public virtual ClientResponseDTO Client { get; set; }
        public Guid AnimalClientId { get; set; }



    }
}
