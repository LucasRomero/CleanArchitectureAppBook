using BookStoreApplication.Books.Query.Get;
using BookStoreApplication.Features.Users.GetByEmail;
using BookStoreApplication.Features.Users.Register;
using BookStoreCore.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
        {

            var command = new RegisterUserCommand(
                Email: request.Email,
                FirstName: request.FirstName,
                LastName: request.LastName,
                Password: request.Password
                );

            await _mediator.Send(command);

            return Ok(command);
        }


        [HttpGet]
        [Route("/GetUserByEmail")]
        public async Task<IActionResult> GetUserByEmail([FromQuery] string email)
        {
            var query = new GetUserByEmailQuery(email);

            var user = await _mediator.Send(query);

            return Ok(user);
        }

        [HttpGet]
        [Route("/GetUserById")]
        public async Task<IActionResult> GetUserById([FromQuery] int id)
        {
            var query = new GetAllBooksQuery();

            IEnumerable<Book> books = await _mediator.Send(query);

            return Ok(books);
        }

    }
}
