using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Create
{
    public class CreateClientValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientValidator()
        {
        }
    }
}