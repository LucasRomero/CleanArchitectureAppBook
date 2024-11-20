using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApplication.Abstractions.Messaging;

namespace BookStoreApplication.Features.Users.Register;
public sealed record RegisterUserCommand(string Email, string FirstName, string LastName, string Password) : ICommand;
