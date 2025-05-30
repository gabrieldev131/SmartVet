using AutoMapper;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Application.Interfaces.Services;
using ConectaFapes.Common.Domain.BaseEntities;
using ConectaFapes.Common.Domain;
using MediatR;
using ConectaFapes.Common.Infrastructure.Interfaces;

namespace SmartVet.Application.Base.BaseCase
{
    public class DeleteHandler<IService, DeleteRequest, Request, Response, Entity> : IRequestHandler<DeleteRequest, TResult<Response>>
        where Entity : BaseEntity
        where Response : BaseDto
        where Request : IRequest<TResult<Response>>
        where DeleteRequest : IRequest<TResult<Response>>
        where IService : IBaseCrudService<Request, Response, Entity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IService _service;
        private readonly IMapper _mapper;

        public DeleteHandler(IUnitOfWork unitOfWork, IService service, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _mapper = mapper;
        }

        public async Task<TResult<Response>> Handle(DeleteRequest deleteRequest, CancellationToken cancellationToken)
        {
            var request = _mapper.Map<Entity>(deleteRequest);
            var response = await _service.Delete(request.Id, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);
            return response;
        }
    }
}