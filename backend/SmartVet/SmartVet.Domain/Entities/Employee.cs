using ConectaFapes.Common.Domain.BaseEntities;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


  namespace SmartVet.Domain.Entities
    {

    using SmartVet.GenericUser;
    public  class Employee extends GenericUser {

      public decimal Salary { get; set; }
      public DateTime Work_start_datr { get; set; }
      public datetime Work_time { get; set; }




    public Employee()
        {
        }
    public Employee(decimal salary,DateTime work_start_datr,datetime work_time)
        {

          var validationErrors = EmployeeValidation(salary,work_start_datr,work_time);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Salary = salary;
          Work_start_datr = work_start_datr;
          Work_time = work_time;




        }

    private List<string>EmployeeValidation(decimal salary,DateTime work_start_datr,datetime work_time)
      {
        var errors = new List<string>();

        // Validations

        return errors;
      }
    }
    }
