using SmartVet.Application.Features.generateReportCase.apointmentReport.DTOs;
using SmartVet.Application.Features.generateReportCase.apointmentReport.UseCases;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.generateReportCase.apointmentReport.Interfaces
{
    public interface IapointmentReportService
    {
        Task<TResult<ICollection<apointmentReportDto>>> Execute(apointmentReportCommand request);
    }
}