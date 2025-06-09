using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartVet.Domain.Entities
{
    public  class Admin : Employee {

        public Admin(string user_name, string email, string password, decimal salary, DateTime work_start_date, DateTime work_time) : base(user_name, email, password, salary, work_start_date, work_time)
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
