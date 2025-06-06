using FluentValidation;

namespace SmartVet.Application.Features.CRUD.VeterinarianEntity.VeterinarianCase.GetAll
{
    public class GetAllVeterinarianValidator : AbstractValidator<GetAllVeterinarianCommand>
    {
        public GetAllVeterinarianValidator()
        {
        }
    }
}