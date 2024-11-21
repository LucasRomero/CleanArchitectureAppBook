using BookStoreApplication.Features.Authors.Create;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Authors.Create
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(x => x.request.author.FullName)
                .NotEmpty().WithMessage("Fullname is required.")
                .MaximumLength(5).WithMessage("Fullname must not exceed 20 characters.");

        }

    }
}
