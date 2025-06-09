using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartVet.Domain.Entities
{

    public  class Service : BaseEntity {

      public string Service_name { get; set; }
      public string Service_description { get; set; }
      public decimal Price { get; set; }

        public Service(string service_name,string service_description,decimal price)
        {

          var validationErrors = ServiceValidation(service_name,service_description,price);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Service_name = service_name;
          Service_description = service_description;
          Price = price;

        }

        private List<string>ServiceValidation(string service_name,string service_description,decimal price)
        {
            var errors = new List<string>();

            // Validations

            return errors;
        }
    }
}
