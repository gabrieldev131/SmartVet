using ConectaFapes.Common.Domain.BaseEntities;
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
      //ManyToOne
      public Client? Client { get; set; }
      public Guid AnimalClientId {get; set; }

      //OneToMany
      public ICollection<Apointment>? Apointments { get; set;}





    public Animal()
        {
        }
    public Animal(string animal_name,string specie,string breed,decimal weight,int birth_year, Guid clientId)
        {

          var validationErrors = AnimalValidation(animal_name,specie,breed,weight,birth_year, clientId);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Animal_name = animal_name;
          Specie = specie;
          Breed = breed;
          Weight = weight;
          Birth_year = birth_year;
          AnimalClientId = clientId;






        }

    private List<string>AnimalValidation(string animal_name,string specie,string breed,decimal weight,int birth_year, Guid clientId)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
