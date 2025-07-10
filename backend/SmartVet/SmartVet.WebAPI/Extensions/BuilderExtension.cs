using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SmartVet.Domain.Security.Account;
using System.Text;

namespace SmartVet.WebApi.Extensions
{
    public static class BuilderExtension
    {
        public static void AddConfiguration(this WebApplicationBuilder builder)
        {
            // Define os valores diretamente no código
            Configuration.Secrets.ApiKey = "MinhaApiKey123";
            Configuration.Secrets.JwtPrivateKey = "MinhaChaveJwtSuperSecreta@123"; 
            Configuration.Secrets.PasswordSaltKey = "MeuSaltSeguro@456";

            Configuration.Email.DefaultFromEmail = "contato@smartvet.com";
            Configuration.Email.ApiKey = "ChaveDoServicoDeEmail";
        }

        public static void AddJwtAuthentication(this WebApplicationBuilder builder)
        {
            var jwtKey = Configuration.Secrets.JwtPrivateKey;

            if (string.IsNullOrWhiteSpace(jwtKey))
                throw new Exception("JwtPrivateKey não definida.");

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtKey));

            builder.Services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    };
                });

            builder.Services.AddAuthorization();
        }
    }
}
