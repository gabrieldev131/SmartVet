﻿using System.ComponentModel.DataAnnotations;

namespace SmartVet.Application.Security.Authentication
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string? Password { get; set; }
    }
}