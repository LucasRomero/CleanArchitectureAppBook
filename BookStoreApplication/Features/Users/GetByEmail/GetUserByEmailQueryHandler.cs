using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.GetByEmail
{
    internal class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByEmailQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetByEmailAsync(request.Email);
        }
    }
}
