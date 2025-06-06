using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.Create
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceCommand>
    {
        public CreateServiceValidator()
        {
        }
    }
}