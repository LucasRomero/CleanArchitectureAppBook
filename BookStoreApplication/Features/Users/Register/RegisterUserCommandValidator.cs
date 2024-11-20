using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.Register
{
    internal sealed class RegisterUserCommandValidator: AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Password).NotEmpty().MinimumLength(8);
        }
    }
}
