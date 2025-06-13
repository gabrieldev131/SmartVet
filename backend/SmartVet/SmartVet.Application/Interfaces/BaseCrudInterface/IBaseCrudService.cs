using MediatR;
using SmartVet.Application.Dto;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Interfaces.BaseCrudInterface
{
    public interface IBaseCrudService<Request, Response, Entity>
    {
        Response Create(Request request, CancellationToken cancellationToken);

        Response Update(Request request, CancellationToken cancellationToken);

        Response Delete(Guid id, CancellationToken cancellationToken);
        ICollection<Response> GetAll();
        Response GetById(Guid id);
    }
}
