using SmartVet.Domain.Security.Shared.Entities;

namespace SmartVet.Domain.Security.Account.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; } = string.Empty;
        public List<User> Users { get; set; } = new();

        public Role(string name)
        {
            Name = name;
        }
    }
}
