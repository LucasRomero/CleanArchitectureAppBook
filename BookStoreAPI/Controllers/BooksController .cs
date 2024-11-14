using BookStoreApplication.Books.Commands.Create;
using BookStoreApplication.Books.Query.Get;
using BookStoreApplication.Dtos;
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

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> RegisterBook([FromBody] BookDTO bookDTO)
        {
            var command = new RegisterBookCommand(bookDTO);
            await _mediator.Send(command);

            return Ok("Libro registrado exitosamente");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var query = new GetAllBooksQuery();
            IEnumerable<BookDTO> books = await _mediator.Send(query);
            return Ok(books);
        }

    }
}
