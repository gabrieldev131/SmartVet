using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Create
{
    public class CreateAnimalValidator : AbstractValidator<CreateAnimalCommand>
    {
        public CreateAnimalValidator()
        {
        }
    }
}