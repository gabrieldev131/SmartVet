using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartVet.Domain.Entities
{

    public  class Animal : BaseEntity {

      public string Animal_name { get; set; }
      public string Specie { get; set; }
      public string Breed { get; set; }
      public decimal Weight { get; set; }
      public int Birth_year { get; set; }
      public ICollection<Apointment>? Apointments { get; set; }
        public Animal(string animal_name,string specie,string breed,decimal weight,int birth_year)
        {

          var validationErrors = AnimalValidation(animal_name,specie,breed,weight,birth_year);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Animal_name = animal_name;
          Specie = specie;
          Breed = breed;
          Weight = weight;
          Birth_year = birth_year;

        }

        private List<string>AnimalValidation(string animal_name,string specie,string breed,decimal weight,int birth_year)
        {
            var errors = new List<string>();

            // Validations

            return errors;
        }
    }
}
