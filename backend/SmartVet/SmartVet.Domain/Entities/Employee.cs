using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartVet.Domain.Entities
{
    public class Employee : GenericUser {

      public decimal Salary { get; set; }
      public DateTime Work_start_date { get; set; }
      public DateTime Work_time { get; set; }

        public Employee(string user_name, string email, string password, decimal salary,DateTime work_start_date,DateTime work_time) : base(user_name, email, password)
        {

            var validationErrors = EmployeeValidation(salary,work_start_date,work_time);

            if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

            Salary = salary;
            Work_start_date = work_start_date;
            Work_time = work_time;

        }

        private List<string>EmployeeValidation(decimal salary,DateTime work_start_date,DateTime work_time)
        {
            var errors = new List<string>();

            // Validations

            return errors;
        }
    }
}
