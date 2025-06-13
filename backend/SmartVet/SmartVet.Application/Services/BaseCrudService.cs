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

        public virtual Response Create(Request request, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
            var entity = _mapper.Map<Entity>(request);

            var result = _mapper.Map<Response>(_repository.Create(entity));
            return result;
        }

        public virtual Response Update(Request request, CancellationToken cancellationToken) 
        {
            if (cancellationToken.IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
            var entity = _mapper.Map<Entity>(request);

            var result = _mapper.Map<Response>(_repository.Update(entity));
            return result;
        }

        public virtual Response Delete(Guid id, CancellationToken cancellationToken) 
        {
            if (cancellationToken.IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
            var response = GetById(id);
            var entity = _mapper.Map<Entity>(response);

            var result = _mapper.Map<Response>(_repository.Delete(entity));
            return result;
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
