using Microsoft.AspNetCore.Identity; 

namespace SmartVet.Domain.Security.Account.Entities
{
    
    public class Role : IdentityRole<Guid> 
    {
        public Role(string name) : base(name) 
        {
        }
    }
}