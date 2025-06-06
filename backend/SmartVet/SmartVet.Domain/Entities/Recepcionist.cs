using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    using SmartVet.Employee;
    public  class Recepcionist extends Employee {





    public Recepcionist()
        {
        }
    public Recepcionist()
        {

          var validationErrors = RecepcionistValidation();

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }






        }

    private List<string>RecepcionistValidation()
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
