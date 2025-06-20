using MediatR;
using SmartVet.Domain.Base;
using SmartVet.Application.Dto;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Base.BaseCase
{
    public class GetAllHandler<IService, GetRequest, Request, Response, Entity> : IRequestHandler<GetRequest, ICollection<Response>>
        where Entity : BaseEntity
        where Response : BaseDto
        where GetRequest : IRequest<ICollection<Response>>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseCrudService<Request, Response, Entity>
    {
        protected readonly IService _service;

        public GetAllHandler(IService service)
        {
            _service = service;
        }


        public async Task<ICollection<Response>> Handle(GetRequest getRequest, CancellationToken cancellationToken)
        {
            return await Task.Run(() => _service.GetAll(), cancellationToken);
        }
    }
}