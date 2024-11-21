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
    public class AuthorRepository : IAuthorRepository
    {

        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Author> AddAsync(Author author)
        {
            _context.Authors.Add(author);

            await _context.SaveChangesAsync();

            return author;
        }

        public Task<Author> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            Author? author = await _context.Authors.SingleOrDefaultAsync(b => b.Id == id);

            // falta validacion de null
            //if (author == null) return;

            return author;
        }

        public Task<Author> UpdateAsync(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
