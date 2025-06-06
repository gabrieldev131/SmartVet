using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Domain.BaseEntities;
using ConectaFapes.Common.Infrastructure.Interfaces;
using SmartVet.Application.Interfaces.BaseGetInterface;

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
            var result = _mapper.Map<ICollection<Response>>(_repository.GetAllAsNoTracking());
            return result;
        }

        public virtual Response GetById(Guid id)
        {
            var result = _mapper.Map<Response>(_repository.GetByIdAsNoTracking(id).FirstOrDefault());
            return result;
        }
    }
}
