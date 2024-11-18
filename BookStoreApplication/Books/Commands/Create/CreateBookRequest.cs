using BookStoreApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Commands.Create
{
    public sealed class CreateBookRequest
    {
        public BookDTO Book { get; set; } = null!;
    }
}
