using MediatR;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Features.CRUD.RecepcionistEntity.DTOs
{
    public class RecepcionistRequestDTO : IRequest<TResult<RecepcionistResponseDTO>>
    {
        public Guid Id {get; set;}



    }
}
