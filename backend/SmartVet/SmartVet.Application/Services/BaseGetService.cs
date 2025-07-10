using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Interfaces.BaseGetInterface;
using SmartVet.Infrastructure.Repositories.Common;
using SmartVet.Application.Dto;
using SmartVet.Domain.Base;

namespace SmartVet.Application.Services.BaseGetService
{
    public class BaseGetService<Request, Response, Entity, Repository> : IBaseGetService<Request, Response, Entity>
       where Entity : BaseEntity
       where Response : BaseDto
       where Repository : IBaseRepository<Entity>
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;
        protected readonly Repository _repository;

        public BaseGetService(IMediator mediator, IMapper mapper, Repository repository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _repository = repository;
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
