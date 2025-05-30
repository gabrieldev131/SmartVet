using SmartVet.Application.Features.generateReportCase.userReport.DTOs;
using SmartVet.Application.Features.generateReportCase.userReport.Interfaces;
using ConectaFapes.Common.Domain.ResultEntities;
using ConectaFapes.Common.Domain;
using MediatR;

namespace SmartVet.Application.Features.generateReportCase.userReport.UseCases
{
    public class userReportHandler :
        IRequestHandler<userReportCommand, TResult<ICollection<userReportDto>>>
    {
        private readonly IuserReportService _service;

        public userReportHandler(IuserReportService service)
        {
            _service = service;
        }

        public async Task<TResult<ICollection<userReportDto>>> Handle(userReportCommand request, CancellationToken cancellationToken)
        {
            return await _service.Execute(request);
        }


    }
}