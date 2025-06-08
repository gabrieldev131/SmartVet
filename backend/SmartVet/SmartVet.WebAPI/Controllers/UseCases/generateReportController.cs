using AutoMapper;
using SmartVet.Application.Features.generateReportCase.apointmentReport.UseCases;using SmartVet.Application.Features.generateReportCase.userReport.UseCases;
using SmartVet.WebApi.Controllers.BaseControllers;
using SmartVet.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SmartVet.WebApi.Controllers.UseCases
{
    [Route("api/SmartVet/GenerateReport")]
    [ApiController]
    public class generateReportController : BaseController
    {

        public generateReportController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }

        [HttpPost("ApointmentReport")]
        public async Task<ActionResult> apointmentReport()
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path}");

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(new apointmentReportCommand(), new CancellationToken());
            stopwatch.Stop();

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return ApiOkResult(response);
        }
        [HttpPost("UserReport")]
        public async Task<ActionResult> userReport()
        {
            _logger.LogInformation($"Requisicao: {Request.Method} - {Request.Path}");

            var stopwatch = Stopwatch.StartNew();
            var response = await _mediator.Send(new userReportCommand(), new CancellationToken());
            stopwatch.Stop();

            _logger.LogInformation($"A requisicao foi realizada com sucesso | Tempo: {stopwatch.ElapsedMilliseconds} ms");
            return ApiOkResult(response);
        }

    }
}