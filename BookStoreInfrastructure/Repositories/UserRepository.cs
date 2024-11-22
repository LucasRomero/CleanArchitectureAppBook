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
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            _context.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            User? user = await _context.Users.SingleOrDefaultAsync(b => b.Id == id);

            return user;
        }

        public async Task<User> UpdateAsync(User item)
        {
            throw new NotImplementedException();
        }
    }
}
