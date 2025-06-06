using AutoMapper;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SmartVet.WebApi.Controllers.BaseControllers
{
    public abstract class BaseGetController<GetAllCommand, GetByIdCommand, Response>
        : BaseController
        where Response : BaseDto
        where GetAllCommand : IRequest<ICollection<Response>>, new()
        where GetByIdCommand : IRequest<Response>
    {
        public BaseGetController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }

        [HttpGet]
        public virtual async Task<ICollection<Response>> GetAll()
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path}");

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(new GetAllCommand(), new CancellationToken());
            stopwatch.Stop();

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return response;
        }

        [HttpGet("{id}")]
        public virtual async Task<Response> GetById(Guid id)
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path}");

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(_mapper.Map<GetByIdCommand>(id), new CancellationToken());
            stopwatch.Stop();

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return response;
        }
    }
}
