using FluentValidation;

namespace SmartVet.Application.Features.CRUD.AdminEntity.AdminCase.GetAll
{
    public class GetAllAdminValidator : AbstractValidator<GetAllAdminCommand>
    {
        public GetAllAdminValidator()
        {
        }
    }
}