using AutoMapper;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Application.Interfaces.Services;
using ConectaFapes.Common.Domain;
using ConectaFapes.Common.Domain.BaseEntities;
using ConectaFapes.Common.Infrastructure.Interfaces;
using MediatR;

namespace SmartVet.Application.Base.BaseCase
{
    public class CreateHandler<IService, CreateRequest, Request, Response, Entity> : IRequestHandler<CreateRequest, TResult<Response>>
        where Entity : BaseEntity
        where Response : BaseDto
        where CreateRequest : IRequest<TResult<Response>>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseCrudService<Request, Response, Entity>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public CreateHandler(IUnitOfWork unitOfWork, IService service, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _mapper = mapper;
        }

        public async Task<TResult<Response>> Handle(CreateRequest createRequest, CancellationToken cancellationToken)
        {
            var request = _mapper.Map<Request>(createRequest);
            var response = await _service.Create(request, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);
            return response;
        }
    }
}