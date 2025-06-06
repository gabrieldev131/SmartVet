using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.Create
{
    public class CreateApointmentValidator : AbstractValidator<CreateApointmentCommand>
    {
        public CreateApointmentValidator()
        {
        }
    }
}