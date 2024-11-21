using AutoMapper;
using BookStoreApplication.Books.Commands.Create;
using BookStoreApplication.Books.Query.Get;
using BookStoreApplication.Dtos;
using BookStoreApplication.Features.Authors.Create;
using BookStoreCore.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> RegisterAuthor([FromBody] CreateAuthorRequest request)
        {
            var command = new CreateAuthorCommand(request);
            await _mediator.Send(command);

            return Ok("Libro registrado exitosamente");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var query = new GetAllBooksQuery();

            IEnumerable<Book> books = await _mediator.Send(query);

            return Ok(books);
        }

    }
}
