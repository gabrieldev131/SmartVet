using SmartVet.Application.Dto;
using SmartVet.Application.Features.CRUD.ApointmentEntity.DTOs;


namespace SmartVet.Application.Features.CRUD.ServiceEntity.DTOs
{
    public class ServiceResponseDTO : BaseDto
    {
        public string Service_name { get; set; }
        public string Service_description { get; set; }
        public decimal Price { get; set; }



    }
}
