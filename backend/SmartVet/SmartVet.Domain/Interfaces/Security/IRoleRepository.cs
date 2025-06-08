using SmartVet.Domain.Security.Account.Entities;

namespace SmartVet.Domain.Interfaces.Security
{
    public interface IRoleRepository : IBaseSecurityRepository<Role>
    {
        Task<Role> GetRoleByName(string name, CancellationToken cancelationToken);
    }
}
