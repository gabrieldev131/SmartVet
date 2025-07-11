using SmartVet.Application.Dto; 

namespace SmartVet.Application.Security.Authentication.DTOs
{
    public class UserResponseDTO : BaseDto // Herde de BaseDto se for a sua convenção
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        // Adicione outras propriedades do seu User que você quer expor
    }
}