using BookStoreApplication.Features.Users.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
        {
            var command = new RegisterUserCommand(request.Email, request.FirstName, request.LastName, request.Password);

            await _mediator.Send(command);

            return Ok("User register was succesfull");
        }
    }
}
