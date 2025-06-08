using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    public  class GenericUser : BaseEntity {

      public string User_name { get; set; }
      public String Email_x { get; set; }
      public string Password { get; set; }




    public GenericUser()
        {
        }
    public GenericUser(string user_name,String email_x,string password)
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

    private List<string>GenericUserValidation(string user_name,String email_x,string password)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
