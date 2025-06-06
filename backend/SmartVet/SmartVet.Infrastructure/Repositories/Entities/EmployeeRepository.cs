using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Interfaces.Entities;
using SmartVet.Infrastructure.Context;
using ConectaFapes.Common.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SmartVet.Infrastructure.Repositories.Entities
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context) { }

    }
}
