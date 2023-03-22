using Clndrprjct.Models;
using Microsoft.EntityFrameworkCore;

namespace Clndrprjct.Data
{
    public class UserRepository
    {
        private readonly UserContext _context = null!;

        public UserRepository(UserContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            return await _context.Users.FindAsync(user.Id);
        }

        public void UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
        }

        public void DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
        }

        public async Task<bool> UserExists(Guid id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}
