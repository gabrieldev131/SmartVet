using AutoMapper;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Application.Interfaces.Services;
using MediatR;
using SmartVet.Domain.Base;
using SmartVet.Application.Dto;
using SmartVet.Application.Interfaces.BaseCrudInterface;

namespace SmartVet.Application.Base.BaseCase
{
    public class GetByIdHandler<IService, GetRequest, Request, Response, Entity> : IRequestHandler<GetRequest, Response>
        where Entity : BaseEntity
        where Response : BaseDto
        where GetRequest : IRequest<Response>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseCrudService<Request, Response, Entity>
    {

        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public GetByIdHandler(IService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);
            return await Task.Run(() => _service.GetById(entity.Id), cancellationToken);
        }
    }
}