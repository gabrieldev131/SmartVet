using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace SmartVet.Domain.Entities
{
    public  class Client : GenericUser {

      public String Identification { get; set; }
      public string Phone_number { get; set; }
      public string Address { get; set; }
      //OneToMany
      public ICollection<Animal>? Animals { get; set;}

        public Client(string user_name, string email, string password, string identification,string phone_number,string address) : base(user_name, email, password)
        {

          var validationErrors = ClientValidation(identification,phone_number,address);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Identification = identification;
          Phone_number = phone_number;
          Address = address;

        }

        private List<string>ClientValidation(String identification,string phone_number,string address)
        {
            var errors = new List<string>();

            string patternCPF = @"/^[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}$/";
            string patternPhone = @"/^\([0-9]{2}\)\9[0-9]{4}\-[0-9]{4}$/";

            Regex rgCPF = new Regex(patternCPF);
            Regex rgPhone = new Regex(patternPhone);

            if (!rgCPF.IsMatch(identification))
            {
                errors.Add("CPF inválido (" +  identification + ")");
            }

            if (!rgPhone.IsMatch(phone_number))
            {
                errors.Add("Telefone inválido (" +  phone_number + ")");
            }

            return errors;
        }
    }
}
