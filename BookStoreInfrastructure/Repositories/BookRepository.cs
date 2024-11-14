using BookStoreCore.Entities;
using BookStoreCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreInfrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> AddAsync(Book book)
        {
            _context.Books.Add(book);

            await _context.SaveChangesAsync();

            return book;
        }

        public Task<Book> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            Book? book = await _context.Books.SingleOrDefaultAsync(b => b.Id == id);

            // falta validacion de null
            //if (book == null) return;

            return book;
        }

        public Task<bool> IsMaxBookLimitReachedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
