using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AnimalEntity.AnimalCase.GetAll
{
    public class GetAllAnimalValidator : AbstractValidator<GetAllAnimalCommand>
    {
        public GetAllAnimalValidator()
        {
        }
    }
}