using SmartVet.Application.Features.generateReportCase.apointmentReport.DTOs;
using SmartVet.Application.Features.generateReportCase.apointmentReport.Interfaces;
using ConectaFapes.Common.Domain.ResultEntities;
using ConectaFapes.Common.Domain;
using MediatR;

namespace SmartVet.Application.Features.generateReportCase.apointmentReport.UseCases
{
    public class apointmentReportHandler :
        IRequestHandler<apointmentReportCommand, TResult<ICollection<apointmentReportDto>>>
    {
        private readonly IapointmentReportService _service;

        public apointmentReportHandler(IapointmentReportService service)
        {
            _service = service;
        }

        public async Task<TResult<ICollection<apointmentReportDto>>> Handle(apointmentReportCommand request, CancellationToken cancellationToken)
        {
            return await _service.Execute(request);
        }


    }
}