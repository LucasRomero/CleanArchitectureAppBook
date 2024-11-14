using BookStoreApplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Commands.Create
{
    public class RegisterBookCommand : IRequest
    {
        public BookDTO Book { get; }

        public RegisterBookCommand(BookDTO bookDTO)
        {
            Book = bookDTO;
        }

    }
}
