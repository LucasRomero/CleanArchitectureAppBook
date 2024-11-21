using BookStoreApplication.Abstractions.Messaging;
using BookStoreApplication.Books.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Authors.Create
{
    public sealed record CreateAuthorCommand(CreateAuthorRequest request) : ICommand<CreateAuthorResponse>;
}
