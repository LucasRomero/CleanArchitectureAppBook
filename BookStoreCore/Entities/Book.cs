using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreCore.Entities
{
    public sealed class Book: BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
        public int Status { get; set; }
    }
}
