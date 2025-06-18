using MediatR;
using SmartVet.Application.Dto;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Interfaces.BaseCrudInterface
{
    public interface IBaseCrudService<Request, Response, Entity>
    {
        Task<TResult<Response>> Create(Request request, CancellationToken cancellationToken);

        Task<TResult<Response>> Update(Request request, CancellationToken cancellationToken);

        Task<TResult<Response>> Delete(Guid id, CancellationToken cancellationToken);
        ICollection<Response> GetAll();
        Response GetById(Guid id);
    }
}
