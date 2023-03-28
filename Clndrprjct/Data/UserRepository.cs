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
            return await _context.Users
                .Include(s => s.CalendarEvents)
                .Include(s => s.Reminders)
                .ToListAsync();
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            return await _context.Users
                .Where(a => a.Id == id)
                .Include(s => s.CalendarEvents)
                .Include(s => s.Reminders)
                .FirstOrDefaultAsync();
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return await _context.Users.FindAsync(user.Id);
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UserExists(Guid id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}
