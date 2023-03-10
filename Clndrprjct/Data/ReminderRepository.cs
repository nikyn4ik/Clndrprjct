using Microsoft.EntityFrameworkCore;
using Clndrprjct.Data;
using Clndrprjct.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clndrprjct.Data
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly CalendarContext _context;

        public ReminderRepository(CalendarContext context)
        {
            _context = context;
        }

        public async Task AddReminderAsync(Reminder reminder)
        {
            await _context.Reminders.AddAsync(reminder);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReminderAsync(Reminder reminder)
        {
            _context.Reminders.Remove(reminder);
            await _context.SaveChangesAsync();
        }

        public async Task<Reminder> GetReminderByIdAsync(int id)
        {
            return await _context.Reminders.FindAsync(id);
        }

        public async Task<IEnumerable<Reminder>> GetRemindersByUserIdAsync(int userId)
        {
            return await _context.Reminders
                .Where(r => r.UserId == userId)
                .ToListAsync();
        }

        public async Task UpdateReminderAsync(Reminder reminder)
        {
            _context.Entry(reminder).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
