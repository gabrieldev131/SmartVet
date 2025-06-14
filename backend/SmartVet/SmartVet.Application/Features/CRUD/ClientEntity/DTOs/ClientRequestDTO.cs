using MediatR;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.CRUD.ClientEntity.DTOs
{
    public class ClientRequestDTO : IRequest<TResult<ClientResponseDTO>>
    {
        public Guid Id {get; set;}
        public String Identification { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }



    }
}
