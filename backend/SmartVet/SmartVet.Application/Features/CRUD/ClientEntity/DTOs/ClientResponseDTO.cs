using SmartVet.Application.Dto;
using SmartVet.Application.Features.CRUD.AnimalEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.ClientEntity.DTOs
{
    public class ClientResponseDTO : BaseDto
    {
        public String Identification { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }



    }
}
