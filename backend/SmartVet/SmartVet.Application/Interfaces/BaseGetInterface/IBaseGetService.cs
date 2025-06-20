using SmartVet.Domain.Base;

namespace SmartVet.Application.Interfaces.BaseGetInterface
{
    public interface IBaseGetService<Request, Response, Entity>
    {
        ICollection<Response> GetAll();
        Response GetById(Guid id);

    }
}