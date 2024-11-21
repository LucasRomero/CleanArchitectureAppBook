using AutoMapper;
using BookStoreApplication.Dtos;
using BookStoreApplication.Features.Authors.Create;
using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Authors.Create
{
    public class RegisterAuthorHandler : IRequestHandler<CreateAuthorCommand, CreateAuthorResponse>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public RegisterAuthorHandler(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<CreateAuthorResponse> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var authorEntity = _mapper.Map<Author>(request.request.author);
            var createdAuthor = await _authorRepository.AddAsync(authorEntity);
            var createdAuthorDTO = _mapper.Map<AuthorDTO>(createdAuthor);

            return new CreateAuthorResponse
            {
                author = createdAuthorDTO,
                Message = "Author created successfully.",
                Success = true
            };
        }

    }
}
