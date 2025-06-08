using SmartVet.Application.Features.generateReportCase.userReport.DTOs;
using ConectaFapes.Common.Domain;
using MediatR;

namespace SmartVet.Application.Features.generateReportCase.userReport.UseCases
{
    public record userReportCommand() : IRequest<TResult<ICollection<userReportDto>>>;
}