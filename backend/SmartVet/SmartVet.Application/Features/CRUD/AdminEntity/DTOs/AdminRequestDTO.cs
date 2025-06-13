using MediatR;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Features.CRUD.AdminEntity.DTOs
{
    public class AdminRequestDTO : IRequest<TResult<AdminResponseDTO>>
    {
        public Guid Id {get; set;}



    }
}
