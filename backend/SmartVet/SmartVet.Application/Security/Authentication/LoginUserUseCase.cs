using SmartVet.Domain.Security.Authentication;

namespace SmartVet.Application.Security.Authentication
{
    public class LoginUserUseCase
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginUserUseCase(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<LoginResponse> ExecuteAsync(LoginRequest request)
        {
            try
            {
                // Aqui você pode adicionar validações de negócio adicionais se necessário
                var token = await _authenticationService.AuthenticateAsync(request.Email, request.Password);

                if (string.IsNullOrEmpty(token))
                {
                    return new LoginResponse { Success = false, Message = "Credenciais inválidas." };
                }

                return new LoginResponse { Success = true, Token = token, Message = "Login realizado com sucesso." };
            }
            catch (Exception ex)
            {
                // Logar a exceção
                return new LoginResponse { Success = false, Message = $"Ocorreu um erro ao tentar logar: {ex.Message}" };
            }
        }
    }
}