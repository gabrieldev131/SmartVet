using FluentValidation;

namespace SmartVet.Application.Features.CRUD.ServiceEntity.ServiceCase.GetAll
{
    public class GetAllServiceValidator : AbstractValidator<GetAllServiceCommand>
    {
        public GetAllServiceValidator()
        {
        }
    }
}