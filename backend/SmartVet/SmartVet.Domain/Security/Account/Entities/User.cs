using SmartVet.Domain.Security.Account.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace SmartVet.Domain.Security.Account.Entities
{
    // SUA CLASSE USER DEVE HERDAR DE IDENTITYUSER<GUID>
    public class User : IdentityUser<Guid> 
    {
        
        public Email UserEmailVO { get; private set; } = null!; 

        public Guid? RefreshToken { get; set; }

        // O construtor padrão é necessário para o EF Core e Identity.
        public User() { }

        public User(string userName, Email emailVo)
        {
            // IdentityUser já cuida do Id.
            this.UserName = userName; // Use para o nome de usuário/login
            this.Email = emailVo.Address; // Atribua a string do seu VO à propriedade Email do IdentityUser
            this.UserEmailVO = emailVo;   // Mantenha seu VO se necessário para validações ou lógica de domínio
        }

        public void UpdateEmail(Email emailVo)
        {
            this.Email = emailVo.Address; // Atualiza a propriedade Email do IdentityUser
            this.UserEmailVO = emailVo; // Atualiza seu Value Object
        }

        public void UpdateRefreshToken(Guid? token)
        {
            RefreshToken = token;
        }

    }
}