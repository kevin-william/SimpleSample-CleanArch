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
            PessoaNomeValidator();
            PessoaEmailValidator();
            PessoaIdadeValidator();
        }

        private void PessoaNomeValidator()
        {
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

        private void PessoaIdadeValidator()
        {
            RuleFor(x => x.Idade)
                .Must(x => x > EntitiesValidationConstants.PessoaIdadeMinimunLength)
                .WithMessage(EntitiesValidationConstants.PessoaIdadeMinimumLenghtMessage);

            RuleFor(x => x.Idade)
                .Must(x => x <= EntitiesValidationConstants.PessoaIdadeMaximumLength)
                .WithMessage(EntitiesValidationConstants.PessoaIdadeMaximumLenghtMessage);

            RuleFor(x => x.Idade)
                .NotNull()
                .WithMessage(EntitiesValidationConstants.PessoaIdadeNullMessage);

            RuleFor(x => x.Idade)
                .NotEmpty()
                .WithMessage(EntitiesValidationConstants.PessoaIdadeNullMessage);
        }

        private void PessoaEmailValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage(EntitiesValidationConstants.PessoaEmailNullMessage);

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(EntitiesValidationConstants.PessoaEmailNullMessage);

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage(EntitiesValidationConstants.PessoaEmailPatternMessage);
        }
    }
}
