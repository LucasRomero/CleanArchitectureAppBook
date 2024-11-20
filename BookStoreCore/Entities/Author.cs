using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreCore.Entities
{
    public sealed class Author: BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set;} = new List<Book>();
        public int Status { get; set; }
    }
}
