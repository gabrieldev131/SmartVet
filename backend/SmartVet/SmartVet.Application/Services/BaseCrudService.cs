using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Interfaces.BaseCrudInterface;
using SmartVet.Infrastructure.Repositories.Common;
using SmartVet.Application.Dto;
using SmartVet.Domain.Base;
using Microsoft.OData.ModelBuilder;

namespace SmartVet.Application.Services.BaseCrudInterface
{
    public class BaseCrudService<Request, Response, Entity, Repository> : IBaseCrudService<Request, Response, Entity>
       where Entity : BaseEntity
       where Response : BaseDto
       where Repository : IBaseRepository<Entity>
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;
        protected readonly Repository _repository;

        public BaseCrudService(IMediator mediator, IMapper mapper, Repository repository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _repository = repository;
        }

        public virtual async Task<TResult<Response>> Create(Request request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);
            
            if (cancellationToken.IsCancellationRequested || entity == null)
            {
                throw new OperationCanceledException();
            }
            await _repository.Create(entity);

            return _mapper.Map<TResult<Response>>(entity);
        }

        public virtual async Task<TResult<Response>> Update(Request request, CancellationToken cancellationToken) 
        {
            var entity = _mapper.Map<Entity>(request);
            var ent = GetById(entity.Id);

            if (cancellationToken.IsCancellationRequested || ent == null)
            {
                throw new OperationCanceledException();
            }

            await _repository.Update(entity);

            return _mapper.Map<TResult<Response>>(entity);
        }

        public virtual async Task<TResult<Response>> Delete(Guid id, CancellationToken cancellationToken) 
        {
            var ent = GetById(id);

            if (cancellationToken.IsCancellationRequested || ent == null)
            {
                throw new OperationCanceledException();
            }

            var entity = _mapper.Map<Entity>(ent);

            await _repository.Delete(entity);

            return _mapper.Map<TResult<Response>>(entity);
        }
        public virtual ICollection<Response> GetAll()
        {
            var result = _mapper.Map<ICollection<Response>>(_repository.GetAll());
            return result;
        }

        public virtual Response GetById(Guid id)
        {
            var result = _mapper.Map<Response>(_repository.GetById(id).FirstOrDefault());
            return result;
        }
    }
}
