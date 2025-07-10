using MediatR;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.DTOs
{
    public class AnimalRequestDTO : IRequest<TResult<AnimalResponseDTO>>
    {
        public Guid Id {get; set;}
        public string? Animal_name { get; set; }
        public string? Specie { get; set; }
        public string? Breed { get; set; }
        public decimal Weight { get; set; }
        public int Birth_year { get; set; }


    }
}
