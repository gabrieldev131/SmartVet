using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartVet.Domain.Security.Account.ValueObjects; // O namespace do seu Value Object Email

namespace SmartVet.Infrastructure.Converters
{
    // Este converter mapeia seu Value Object Email para uma string no banco de dados.
    public class EmailValueConverter : ValueConverter<Email, string>
    {
        public EmailValueConverter()
            : base(
                email => email.Address, // Como converter de Email (VO) para string (banco)
                address => new Email(address)) // Como converter de string (banco) para Email (VO)
        { }
    }
}