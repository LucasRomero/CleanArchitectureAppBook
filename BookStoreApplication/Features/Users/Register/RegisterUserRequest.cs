using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Users.Register
{
    public record RegisterUserRequest(string Email, string FirstName, string LastName, string Password);
}
