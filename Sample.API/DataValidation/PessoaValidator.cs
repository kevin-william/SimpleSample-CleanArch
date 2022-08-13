using FluentValidation;
using Sample.API.Constants;
using Sample.Domain.Models;
using System.Text.RegularExpressions;

namespace Sample.API.DataValidation
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Email)
                .NotNull();

            RuleFor(x => x.Email)
                .NotEmpty();

            RuleFor(x => x.Email)
                .EmailAddress();

            RuleFor(x => x.Nome)
                .NotNull()
                .WithMessage(EntitiesValidationConstants.PessoaNomeNullMessage);

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage(EntitiesValidationConstants.PessoaNomeNullMessage);

            RuleFor(x => x.Nome)
                .MinimumLength(EntitiesValidationConstants.PessoaNomeMinimumLength)
                .WithMessage(EntitiesValidationConstants.PessoaNomeMinimumLengthMessage);

            RuleFor(x => x.Nome)
                .MaximumLength(EntitiesValidationConstants.PessoaNomeMaximumLength)
                .WithMessage(EntitiesValidationConstants.PessoaNomeMaximumLengthMessage);

            RuleFor(x => x.Nome)
                .Must(x => new Regex(EntitiesValidationConstants.PessoaNomePattern)
                .IsMatch(x))
                .WithMessage(EntitiesValidationConstants.PessoaNomePatternMessage);
        }
    }
}
