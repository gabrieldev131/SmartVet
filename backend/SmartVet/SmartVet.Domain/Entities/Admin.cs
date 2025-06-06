using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    using SmartVet.Employee;
    public  class Admin extends Employee {





    public Admin()
        {
        }
    public Admin()
        {

          var validationErrors = AdminValidation();

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }






        }

    private List<string>AdminValidation()
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
