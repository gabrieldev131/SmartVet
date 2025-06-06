using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Interfaces.BaseGetInterface
{
    public interface IBaseGetService<Request, Response, Entity>
    {
        ICollection<Response> GetAll();
        Response GetById(Guid id);

    }
}