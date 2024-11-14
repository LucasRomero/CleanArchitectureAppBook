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

            var book = request.Book;

            var author = await _authorRepository.GetByIdAsync(book.AuthorId);

            if (author == null) { throw new Exception("The author is not registered"); }

            await _bookRepository.AddAsync(book);

        }
    }
}
