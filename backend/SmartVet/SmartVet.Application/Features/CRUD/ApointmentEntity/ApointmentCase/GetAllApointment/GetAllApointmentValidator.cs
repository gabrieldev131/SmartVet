using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ApointmentEntity.ApointmentCase.GetAll
{
    public class GetAllApointmentValidator : AbstractValidator<GetAllApointmentCommand>
    {
        public GetAllApointmentValidator()
        {
        }
    }
}