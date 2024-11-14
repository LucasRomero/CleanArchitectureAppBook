using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Books.Commands.Create
{
    public class RegisterBookHandler : IRequestHandler<RegisterBookCommand>
    {

        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public RegisterBookHandler(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public async Task Handle(RegisterBookCommand request, CancellationToken cancellationToken)
        {
            // falta validacion (libreria)
            // falta mapper (libreria)

            var bookDto = request.Book;

            var author = await _authorRepository.GetByIdAsync(bookDto.AuthorId);

            if (author == null) { throw new Exception("The author is not registered"); }

            var book = new Book
            {
                AuthorId = bookDto.AuthorId,
                Genre = bookDto.Genre,
                PageCount = bookDto.PageCount,
                Title = bookDto.Title,
                Author = author,
                Year = bookDto.Year,
            };

            await _bookRepository.AddAsync(book);

        }
    }
}
