using FluentValidation;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.Create
{
    public class CreateVeterinarianValidator : AbstractValidator<CreateVeterinarianCommand>
    {
        public CreateVeterinarianValidator()
        {
        }
    }
}