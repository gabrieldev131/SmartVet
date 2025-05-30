using SmartVet.Application.Features.generateReportCase.apointmentReport.DTOs;
using ConectaFapes.Common.Domain;
using MediatR;

namespace SmartVet.Application.Features.generateReportCase.apointmentReport.UseCases
{
    public record apointmentReportCommand() : IRequest<TResult<ICollection<apointmentReportDto>>>;
}