using BookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreCore.Interfaces
{
    public interface IBookRepository: IRepository<Book>
    {
        Task<bool> IsMaxBookLimitReachedAsync();
    }
}
