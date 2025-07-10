using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using SmartVet.Application.Security.Authentication;

namespace SmartVet.WebApi.Controllers.Entities
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly LoginUserUseCase _loginUserUseCase;

        public AccountController(LoginUserUseCase loginUserUseCase)
        {
            _loginUserUseCase = loginUserUseCase;
        }

        /// <summary>
        /// Realiza o login do usuário e retorna um token JWT.
        /// </summary>
        /// <param name="request">As credenciais de login (email e senha).</param>
        /// <returns>Um token JWT se o login for bem-sucedido.</returns>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] SmartVet.Application.Security.Authentication.LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _loginUserUseCase.ExecuteAsync(request);

            if (!response.Success)
            {
                // Se as credenciais forem inválidas, retorna 401 Unauthorized
                if (response.Message == "Credenciais inválidas.")
                {
                    return Unauthorized(response);
                }
                return BadRequest(response); // Para outros erros, retorna 400 Bad Request
            }

            return Ok(response);
        }

        // Exemplo de rota protegida
        /// <summary>
        /// Exemplo de rota que exige autenticação.
        /// </summary>
        [HttpGet("protected")]
        [Microsoft.AspNetCore.Authorization.Authorize] // Exige autenticação
        public IActionResult Protected()
        {
            return Ok("Você acessou uma rota protegida!");
        }

        // Exemplo de rota protegida por role
        /// <summary>
        /// Exemplo de rota que exige autenticação e uma role específica.
        /// </summary>
        [HttpGet("admin-only")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")] // Exige autenticação e role "Admin"
        public IActionResult AdminOnly()
        {
            return Ok("Você acessou uma rota de administrador!");
        }
    }
}