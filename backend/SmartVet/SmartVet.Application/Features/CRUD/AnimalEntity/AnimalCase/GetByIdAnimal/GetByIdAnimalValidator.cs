using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetById
{
    public class GetByIdAnimalValidator : AbstractValidator<GetByIdAnimalCommand>
    {
        public GetByIdAnimalValidator()
        {

        }
    }
}