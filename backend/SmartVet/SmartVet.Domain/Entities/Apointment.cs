using SmartVet.Domain.Base;
using SmartVet.Domain.Enums;
using SmartVet.Domain.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartVet.Domain.Entities
{

    public  class Apointment : BaseEntity {

      public DateTime Scheduled_date { get; set; }
      public int Urgency { get; set; }
      public string Result_description { get; set; }
      //ManyToOne
      public Animal? Animal { get; set; }
      public Guid ApointmentAnimalId {get; set; }

      //ManyToOne
      public Veterinarian? Veterinarian { get; set; }
      public Guid ApointmentVeterinarianId {get; set; }

      //ManyToMany
      public ICollection<Service>? Services { get; set;}

        public Apointment(DateTime scheduled_date,int urgency,string result_description, Guid animalId,Guid veterinarianId,ICollection<Service>? services)
        {

          var validationErrors = ApointmentValidation(scheduled_date,urgency,result_description, animalId,veterinarianId,services);

          if (validationErrors.Count > 0)
            {
              throw new DomainValidationException(validationErrors);
            }

          Scheduled_date = scheduled_date;
          Urgency = urgency;
          Result_description = result_description;
          ApointmentAnimalId = animalId;

          ApointmentVeterinarianId = veterinarianId;

          Services = services;

        }

        private List<string>ApointmentValidation(DateTime scheduled_date,int urgency,string result_description, Guid animalId,Guid veterinarianId,ICollection<Service>? services)
        {
            var errors = new List<string>();

            // Validations

            return errors;
        }
    }
}
