using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.Create
{
    public class CreateAdminValidator : AbstractValidator<CreateAdminCommand>
    {
        public CreateAdminValidator()
        {
        }
    }
}