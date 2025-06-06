using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    using SmartVet.GenericUser;
    public  class Client extends GenericUser {

      public String Identification { get; set; }
      public string Phone_number { get; set; }
      public string Address { get; set; }
      //OneToMany
      public ICollection<Animal>? Animals { get; set;}





    public Client()
        {
        }
    public Client(String identification,string phone_number,string address)
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

        // Validations

        return errors;
      }
    }
    }
