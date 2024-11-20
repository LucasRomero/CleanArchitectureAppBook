using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.GetById
{
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetByIdAsync(request.id);

        }
    }
}
