using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    using SmartVet.GenericUser;
    public  class Veterinarian extends GenericUser {

      public string Crmv { get; set; }
      public string Speciality { get; set; }
      //OneToMany
      public ICollection<Apointment>? Apointments { get; set;}





    public Veterinarian()
        {
        }
    public Veterinarian(string crmv,string speciality)
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

        // Validations

        return errors;
      }
    }
    }
