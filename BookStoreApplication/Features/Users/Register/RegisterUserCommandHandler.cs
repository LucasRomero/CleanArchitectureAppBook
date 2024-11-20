using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.Register
{
    internal class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;
        public RegisterUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {

            var user = new User
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PasswordHash = request.Password,
            };

            var createUser = await _userRepository.AddAsync(user);
        }
    }
}
