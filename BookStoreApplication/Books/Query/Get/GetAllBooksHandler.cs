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
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreApplication.Books.Query.Get
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public GetAllBooksHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            // hacer un response? o hacer varios?

            //var bookDtos = _mapper.Map<IEnumerable<BookDTO>>(books);

            return await _bookRepository.GetAllAsync();

        }
    }
}
