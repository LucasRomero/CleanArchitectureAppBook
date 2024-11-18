using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Commands.Create
{
    public class CreateBookCommandValidator: AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(x => x.request.Book.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(5).WithMessage("Title must not exceed 5 characters.");

            RuleFor(x => x.request.Book.AuthorId)
                .GreaterThan(0).WithMessage("AuthorId must be greater than zero.");
        }

    }
}
