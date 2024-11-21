using BookStoreApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Authors.Create
{
    public sealed class CreateAuthorRequest
    {
        public AuthorDTO author { get; set; } = null!;
    }
}
