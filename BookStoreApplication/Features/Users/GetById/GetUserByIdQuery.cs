using BookStoreCore.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.GetById
{
    public sealed record GetUserByIdQuery(int id): IRequest<User>;
}
