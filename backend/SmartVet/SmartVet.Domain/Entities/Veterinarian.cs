using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartVet.Domain.Entities
{
    public  class Veterinarian : GenericUser {

      public string Crmv { get; set; }
      public string Speciality { get; set; }
      //OneToMany
      public ICollection<Apointment>? Apointments { get; set;}

        public Veterinarian(string user_name, string email, string password, string crmv,string speciality) : base(user_name, email, password)
        {

          var validationErrors = VeterinarianValidation(crmv,speciality);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Crmv = crmv;
          Speciality = speciality;

        }

        private List<string>VeterinarianValidation(string crmv,string speciality)
        {
            var errors = new List<string>();

            // Adicionar validação de crmv

            return errors;
        }
    }
}
