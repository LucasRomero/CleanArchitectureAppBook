using BookStoreApplication.Dtos;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Query.Get
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<BookDTO>>
    {
        private readonly IBookRepository _bookRepository;
        public GetAllBooksHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<BookDTO>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            // falta validacion (libreria)
            // falta mapper (libreria)

            var books = await _bookRepository.GetAllAsync();

            return books.Select(book => new BookDTO
            {
                Title = book.Title,
                Year = book.Year,
                Genre = book.Genre,
                PageCount = book.PageCount,
                AuthorId = book.AuthorId
            });

        }
    }
}
