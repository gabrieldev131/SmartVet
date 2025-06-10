using Microsoft.EntityFrameworkCore;
using SmartVet.Infrastructure.Interfaces.Security;
using SmartVet.Domain.Security.Account.Entities;
using SmartVet.Infrastructure.Context;

namespace SmartVet.Infrastructure.Security.Repositories
{
    public class RoleRepository : BaseSecurityRepository<Role>, IRoleRepository
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Role> GetRoleByName(string name, CancellationToken cancelationToken)
        {
            return _context.Roles.FirstOrDefaultAsync(x => x.Name == name, cancellationToken: cancelationToken);
        }
    }
}
