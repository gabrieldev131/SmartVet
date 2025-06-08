using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.GetAll
{
    public class GetAllClientValidator : AbstractValidator<GetAllClientCommand>
    {
        public GetAllClientValidator()
        {
        }
    }
}