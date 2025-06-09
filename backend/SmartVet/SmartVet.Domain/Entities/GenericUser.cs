using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace SmartVet.Domain.Entities
{

    public  class GenericUser : BaseEntity {

      public string User_name { get; set; }
      public string Email_x { get; set; }
      public string Password { get; set; }

        public GenericUser(string user_name, string email_x,string password)
        {

            var validationErrors = GenericUserValidation(user_name,email_x,password);

            if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

            User_name = user_name;
            Email_x = email_x;
            Password = password;

        }

        private List<string>GenericUserValidation(string user_name,string email_x,string password)
        {
            var errors = new List<string>();

            string pattern = @"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i";
            Regex rg = new Regex(pattern);

            if (!rg.IsMatch(email_x))
            {
                errors.Add("Email inválido (" +  email_x + ")");
            }

            return errors;
        }
    }
}
