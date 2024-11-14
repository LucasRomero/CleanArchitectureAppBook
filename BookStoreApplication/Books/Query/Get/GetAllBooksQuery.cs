using BookStoreApplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Query.Get
{
    public class GetAllBooksQuery : IRequest<IEnumerable<BookDTO>>
    {
    }
}
