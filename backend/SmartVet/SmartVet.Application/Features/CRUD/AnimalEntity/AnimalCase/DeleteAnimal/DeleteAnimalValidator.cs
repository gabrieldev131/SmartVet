using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.Delete
{
    public class DeleteAnimalValidator : AbstractValidator<DeleteAnimalCommand>
    {
        public DeleteAnimalValidator()
        {

        }
    }
}