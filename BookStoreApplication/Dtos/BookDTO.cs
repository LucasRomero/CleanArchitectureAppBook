using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Dtos
{
    public class BookDTO
    {
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int Status { get; set; }
    }
}
