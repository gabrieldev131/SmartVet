using SmartVet.Application.Features.generateReportCase.userReport.DTOs;
using SmartVet.Application.Features.generateReportCase.userReport.UseCases;
using ConectaFapes.Common.Domain;

namespace SmartVet.Application.Features.generateReportCase.userReport.Interfaces
{
    public interface IuserReportService
    {
        Task<TResult<ICollection<userReportDto>>> Execute(userReportCommand request);
    }
}