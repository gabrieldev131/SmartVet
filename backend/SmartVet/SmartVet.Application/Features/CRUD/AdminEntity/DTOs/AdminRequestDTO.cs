using MediatR;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.CRUD.AdminEntity.DTOs
{
    public class AdminRequestDTO : IRequest<TResult<AdminResponseDTO>>
    {
        public Guid Id {get; set;}



    }
}
