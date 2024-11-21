using BookStoreApplication.Abstractions.Messaging;
using BookStoreApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Features.Authors.Create
{
    public class CreateAuthorResponse
    {
        public AuthorDTO author { get; set; } = null!;
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; }
    }
}