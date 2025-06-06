using SmartVet.Application.Features.generateReportCase.userReport.DTOs;
using SmartVet.Application.Features.generateReportCase.userReport.Interfaces;
using SmartVet.Application.Features.generateReportCase.userReport.UseCases;
using ConectaFapes.Common.Domain;
using ConectaFapes.Common.Domain.ResultEntities;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces.Entities;

namespace SmartVet.Application.Features.generateReportCase.userReport.Services
{
    /// <summary>
    /// Generate the Reports of the System's Users
    /// </summary>
    public class userReportService : IuserReportService
    {

        public userReportService()
        {

        }

        public async Task<TResult<ICollection<userReportDto>>> Execute(userReportCommand request)
        {
            throw new NotImplementedException();
        }

    }
}
