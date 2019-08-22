using Aps19.Domain.Entities;
using FluentValidation;
using System;

namespace APS19.Service.Validators
{
    public class UsuarioValidators : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });

            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Is necessary to inform the Login.")
                .NotNull().WithMessage("Is necessary to inform the Login.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Is necessary to inform the E-mail.")
                .NotNull().WithMessage("Is necessary to inform the E-mail.");

            RuleFor(c => c.Passaword)
                .NotEmpty().WithMessage("Is necessary to inform the Password.")
                .NotNull().WithMessage("Is necessary to inform the Password.");
        }
    }
}
