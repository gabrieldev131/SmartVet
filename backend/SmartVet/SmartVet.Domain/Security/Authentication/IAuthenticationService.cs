namespace SmartVet.Domain.Security.Authentication
{
    public interface IAuthenticationService
    {
        Task<string> AuthenticateAsync(string email, string password);
    }
}
