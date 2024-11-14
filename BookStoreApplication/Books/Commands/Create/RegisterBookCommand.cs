using BookStoreApplication.Dtos;
using BookStoreCore.Entities;
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
        public Book Book { get; }

        public RegisterBookCommand(Book book)
        {
            Book = book;
        }

    }
}
