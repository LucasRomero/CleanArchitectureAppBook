using AutoMapper;
using BookStoreApplication.Books.Commands.Create;
using BookStoreApplication.Books.Query.Get;
using BookStoreApplication.Dtos;
using BookStoreCore.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BooksController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> RegisterBook([FromBody] CreateBookRequest request)
        {
            var command = new CreateBookCommand(request);
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
