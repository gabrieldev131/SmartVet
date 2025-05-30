using SmartVet.Application.Features.generateReportCase.apointmentReport.DTOs;
using SmartVet.Application.Features.generateReportCase.apointmentReport.Interfaces;
using SmartVet.Application.Features.generateReportCase.apointmentReport.UseCases;
using ConectaFapes.Common.Domain;
using ConectaFapes.Common.Domain.ResultEntities;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;

namespace SmartVet.Application.Features.generateReportCase.apointmentReport.Services
{
    /// <summary>
    /// Generate the Reports of the System's Apointments
    /// </summary>
    public class apointmentReportService : IapointmentReportService
    {

        public apointmentReportService()
        {

        }

        public async Task<TResult<ICollection<apointmentReportDto>>> Execute(apointmentReportCommand request)
        {
            throw new NotImplementedException();
        }

    }
}
