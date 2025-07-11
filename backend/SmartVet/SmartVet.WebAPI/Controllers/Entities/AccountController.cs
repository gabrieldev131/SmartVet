// SmartVet.WebApi.Controllers.Entities/AccountController.cs
using Microsoft.AspNetCore.Http; // Para HttpContext.Request
using Microsoft.AspNetCore.Identity; // Para UserManager e RoleManager
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartVet.Application.Security.Authentication;
using SmartVet.Application.Security.Authentication.DTOs;
using SmartVet.Domain.Base; // Para TResult e ApiResponse
using SmartVet.Domain.Security.Account.Entities; // Sua classe User e Role
using SmartVet.Domain.Validation; // Para ResultType
using SmartVet.WebApi.Controllers.BaseControllers;
using System.Linq; // Para Select

namespace SmartVet.WebApi.Controllers.Entities
{
    [ApiController]
    [Route("api/SmartVet/Account")]
    public class AccountController : BaseControllerResult // Herdar de BaseControllerResult
    {
        private readonly LoginUserUseCase _loginUserUseCase;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AccountController(
            LoginUserUseCase loginUserUseCase,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            _loginUserUseCase = loginUserUseCase;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /// <summary>
        /// Realiza o login do usuário e retorna um token JWT.
        /// </summary>
        [HttpPost("login")]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous] // Adicionar para permitir acesso sem autenticação
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] SmartVet.Application.Security.Authentication.LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                // Adaptar para seu ApiResponse de erro de validação
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return ApiBadRequestResult(TResult<LoginResponse>.Failure(ResultType.BAD_REQUEST, errors));
            }

            var response = await _loginUserUseCase.ExecuteAsync(request);

            if (!response.Success)
            {
                if (response.Message == "Credenciais inválidas.")
                {
                    // Usa UnauthorizedObjectResult diretamente para 401
                    return Unauthorized(new ApiResponse(401, "Unauthorized", response.Message));
                }
                // Para outros erros, retorna 400 Bad Request
                return ApiBadRequestResult(TResult<LoginResponse>.Failure(ResultType.BAD_REQUEST, new List<string> { response.Message }));
            }

            return ApiOkResult(TResult<LoginResponse>.Success(response));
        }

        // --- MÉTODOS CRUD PARA USUÁRIOS ---

        /// <summary>
        /// Registra um novo usuário.
        /// </summary>
        [HttpPost("register")]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous] // Permitir registro sem autenticação
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request) // Crie esta classe DTO em Application.Security.Authentication.DTOs
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return ApiBadRequestResult(TResult<string>.Failure(ResultType.BAD_REQUEST, errors));
            }

            var user = new User { UserName = request.Email, Email = request.Email };
            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                // Opcional: Adicionar a uma Role padrão, ex: "Client"
                if (!await _roleManager.RoleExistsAsync("Client"))
                {
                    await _roleManager.CreateAsync(new Role("Client")); // Sua classe Role deve ter um construtor que aceita o nome
                }
                await _userManager.AddToRoleAsync(user, "Client");

                // Você pode retornar o ID do usuário ou um DTO de sucesso
                return ApiCreateResult(TResult<UserResponseDTO>.Success(new UserResponseDTO { Id = user.Id, Email = user.Email }), user.Id, Request);
            }

            var errorsList = result.Errors.Select(e => e.Description).ToList();
            return ApiBadRequestResult(TResult<string>.Failure(ResultType.BAD_REQUEST, errorsList));
        }

        /// <summary>
        /// Obtém um usuário por ID (requer autenticação e permissão de Admin).
        /// </summary>
        [HttpGet("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")] // Apenas Admin pode listar todos os usuários
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserResponseDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return ApiBadRequestResult(TResult<string>.Failure(ResultType.NOT_FOUND, new List<string> { "Usuário não encontrado." }));
            }
            // Mapeie para um DTO de resposta para evitar expor senhas/hashes
            return ApiOkResult(TResult<UserResponseDTO>.Success(new UserResponseDTO { Id = user.Id, Email = user.Email /*, outras props */ }));
        }

        /// <summary>
        /// Lista todos os usuários (requer autenticação e permissão de Admin).
        /// </summary>
        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")] // Apenas Admin pode listar todos os usuários
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ICollection<UserResponseDTO>))]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            var userDtos = users.Select(u => new UserResponseDTO { Id = u.Id, Email = u.Email }).ToList(); // Mapear para DTOs

            return ApiOkResult(TResult<List<UserResponseDTO>>.Success(userDtos));
        }

        /// <summary>
        /// Atualiza informações de um usuário (requer autenticação e permissão de Admin, ou ser o próprio usuário).
        /// </summary>
        [HttpPut("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize] // Usuário logado ou Admin
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)] // Se não for admin e não for o próprio usuário
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UpdateUserRequest request) // Crie esta classe DTO
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return ApiBadRequestResult(TResult<string>.Failure(ResultType.BAD_REQUEST, errors));
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return ApiBadRequestResult(TResult<string>.Failure(ResultType.NOT_FOUND, new List<string> { "Usuário não encontrado." }));
            }

            // Checagem de autorização: só pode editar se for admin OU o próprio usuário
            if (!User.IsInRole("Admin") && user.Id != Guid.Parse(User.Identity.Name)) // Assumindo que User.Identity.Name é o ID do usuário
            {
                // Ou User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                return Forbid("Você não tem permissão para atualizar este usuário.");
            }

            user.Email = request.Email;
            user.UserName = request.Email; // Geralmente o UserName é o email

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return ApiOkResult(TResult<string>.Success("Usuário atualizado com sucesso."));
            }

            var errorsList = result.Errors.Select(e => e.Description).ToList();
            return ApiBadRequestResult(TResult<string>.Failure(ResultType.BAD_REQUEST, errorsList));
        }

        /// <summary>
        /// Deleta um usuário (requer autenticação e permissão de Admin).
        /// </summary>
        [HttpDelete("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")] // Apenas Admin pode deletar usuários
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return ApiBadRequestResult(TResult<string>.Failure(ResultType.NOT_FOUND, new List<string> { "Usuário não encontrado." }));
            }

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return ApiOkResult(TResult<string>.Success("Usuário deletado com sucesso."));
            }

            var errorsList = result.Errors.Select(e => e.Description).ToList();
            return ApiBadRequestResult(TResult<string>.Failure(ResultType.BAD_REQUEST, errorsList));
        }

        // Seus exemplos de rotas protegidas
        [HttpGet("protected")]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult Protected()
        {
            return Ok("Você acessou uma rota protegida!");
        }

        [HttpGet("admin-only")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public IActionResult AdminOnly()
        {
            return Ok("Você acessou uma rota de administrador!");
        }
    }
}