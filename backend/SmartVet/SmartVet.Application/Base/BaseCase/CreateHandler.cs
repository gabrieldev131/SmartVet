using AutoMapper;
using MediatR;
using SmartVet.Domain.Base;
using SmartVet.Infrastructure.Repositories.Common;
using SmartVet.Application.Dto;
using SmartVet.Application.Interfaces.BaseCrudInterface;


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