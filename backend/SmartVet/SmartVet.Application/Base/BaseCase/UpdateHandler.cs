using AutoMapper;
using MediatR;
using SmartVet.Domain.Base;
using SmartVet.Application.Dto;
using SmartVet.Application.Interfaces.BaseCrudInterface;
using SmartVet.Infrastructure.Repositories.Common;

namespace SmartVet.Application.Base.BaseCase
{
    public class UpdateHandler<IService, UpdateRequest, Request, Response, Entity> : IRequestHandler<UpdateRequest, TResult<Response>>
        where Entity : BaseEntity
        where Response : BaseDto
        where UpdateRequest : IRequest<TResult<Response>>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseCrudService<Request, Response, Entity>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IService _service;
        private readonly IMapper _mapper;

        public UpdateHandler(IUnitOfWork unitOfWork, IService service, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _mapper = mapper;
        }

        public async Task<TResult<Response>> Handle(UpdateRequest updateRequest, CancellationToken cancellationToken)
        {
            var request = _mapper.Map<Request>(updateRequest);
            var response = await _service.Update(request, cancellationToken);
            await _unitOfWork.Commit(cancellationToken);
            return response;
        }
    }
}