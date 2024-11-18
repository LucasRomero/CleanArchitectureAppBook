using AutoMapper;
using BookStoreApplication.Dtos;
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
    public class RegisterBookHandler : IRequestHandler<CreateBookCommand, CreateBookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public RegisterBookHandler(IBookRepository bookRepository, IAuthorRepository authorRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<CreateBookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var bookEntity = _mapper.Map<Book>(request.request.Book); // Asegúrate de que el Request tenga Book
            var createdBook = await _bookRepository.AddAsync(bookEntity);
            var createdBookDTO = _mapper.Map<BookDTO>(createdBook);

            return new CreateBookResponse
            {
                Book = createdBookDTO,
                Message = "Book created successfully.",
                Success = true
            };
        }
    }
}
