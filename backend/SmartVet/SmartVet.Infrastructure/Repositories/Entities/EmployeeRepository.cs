using SmartVet.Domain.Entities;
using SmartVet.Domain.Enums;
using SmartVet.Infrastructure.Interfaces.Entities;
using SmartVet.Infrastructure.Context;
using SmartVet.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace SmartVet.Infrastructure.Repositories.Entities
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context) { }

    }
}
