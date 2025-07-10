using SmartVet.Domain.Security.Account.Entities;

namespace SmartVet.Infrastructure.Interfaces.Security
{
    public interface IRoleRepository : IBaseSecurityRepository<Role>
    {
        Task<Role> GetRoleByName(string name, CancellationToken cancelationToken);
    }
}
