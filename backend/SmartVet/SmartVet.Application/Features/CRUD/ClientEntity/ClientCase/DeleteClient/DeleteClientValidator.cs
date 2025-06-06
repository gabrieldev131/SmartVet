using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ClientEntity.ClientCase.Delete
{
    public class DeleteClientValidator : AbstractValidator<DeleteClientCommand>
    {
        public DeleteClientValidator()
        {

        }
    }
}