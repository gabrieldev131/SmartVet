using System.ComponentModel.DataAnnotations;

namespace SmartVet.Application.Security.Authentication.DTOs
{
    public class UpdateUserRequest
    {
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        // Adicione outras propriedades que podem ser atualizadas
    }
}