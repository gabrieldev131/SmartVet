using AutoMapper;
using SmartVet.Domain.Base;
using SmartVet.Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SmartVet.WebApi.Controllers.BaseControllers
{
    public abstract class BaseCrudController<GetAllCommand, GetByIdCommand, CreateCommand, UpdateCommand, DeleteCommand, Response>
        : BaseController
        where Response : BaseDto
        where GetAllCommand : IRequest<ICollection<Response>>, new()
        where GetByIdCommand : IRequest<Response>
        where CreateCommand : IRequest<TResult<Response>>
        where UpdateCommand : IRequest<TResult<Response>>
        where DeleteCommand : IRequest<TResult<Response>>
    {
        public BaseCrudController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
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

        [HttpPost]
        public virtual async Task<ActionResult> Create(CreateCommand Command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path} | Recebeu como parametro: {Command}");

            if (Command == null)
            {
                string error = "O corpo da requisicao nao pode ser vazio";
                _logger.LogError(error);
                return BadRequest(error);
            }

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(Command, cancellationToken);
            stopwatch.Stop();

            if (!response.IsSuccess || response.Value == null || response.Value.Id == Guid.Empty)
            {
                _logger.LogError($"O processo falhou, Mensagem: {response.Errors.FirstOrDefault()} - Erros: {response.Errors}");
                return ApiBadRequestResult(response);
            }

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Item Criado: {response.Value} | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return ApiCreateResult(response, response.Value.Id, Request);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update(Guid id, UpdateCommand Command, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path} | Recebeu como parametro: {Command}");

            if (Command == null)
            {
                string error = "O corpo da requisicao nao pode ser vazio";
                _logger.LogError(error);
                return BadRequest(error);
            }

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(Command, cancellationToken);
            stopwatch.Stop();

            if (!response.IsSuccess)
            {
                _logger.LogError($"O processo falhou, Mensagem: {response.Errors.FirstOrDefault()} - Erros: {response.Errors}");
                return ApiBadRequestResult(response);
            }

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Item Atualizado: {response.Value} | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return ApiOkResult(response);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Requisicao:  {Request.Method} -  {Request.Path} recebeu como parametro: {id}");

            if (id == Guid.Empty)
            {
                string error = "Id nao pode ser vazio";
                _logger.LogError(error);
                return BadRequest(error);
            }

            var stopwatch = Stopwatch.StartNew();
            var Command = _mapper.Map<DeleteCommand>(id);
            var response = await _mediator.Send(Command, cancellationToken);
            stopwatch.Stop();

            if (!response.IsSuccess)
            {
                _logger.LogError($"O processo falhou, Mensagem: {response.Errors.FirstOrDefault()} - Erros: {response.Errors}");
                return ApiBadRequestResult(response);
            }

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Item Deletado: {id} | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return ApiOkResult(response);
        }
    }
}
