

using FluentValidation;

namespace ApiDotNet6.Application.DTOs.Validations
{
    public class PersonDTOValidator : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidator()
        {
            RuleFor(p => p.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("Documento deve ser informado!");

            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name deve ser informado!");

            RuleFor(p => p.Phone)
                .NotNull()
                .NotEmpty()
                .WithMessage("Phone deve ser informado!");
        }
    }
}
