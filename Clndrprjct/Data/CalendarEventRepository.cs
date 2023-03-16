using Clndrprjct.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clndrprjct.Data
{
    public class CalendarEventRepository
    {
        private readonly CalendarContext _context;

        public CalendarEventRepository(CalendarContext context)
        {
            _context = context;
        }

        //public async Task<CalendarEvent> GetCalendarEventByIdAsync(int id)
        //{

        //}

        //public async Task<IEnumerable<CalendarEvent>> GetCalendarEventsByUserIdAsync(int userId)
        //{

        //}

        public async Task AddCalendarEventAsync(CalendarEvent calendarEvent)
        {

        }

        public async Task UpdateCalendarEventAsync(CalendarEvent calendarEvent)
        {

        }

        public async Task DeleteCalendarEventAsync(CalendarEvent calendarEvent)
        {

        }

        public bool CalendarEventExists(int id)
        {
            return (_context.Find<CalendarEvent>(id) != null);
        }

        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetCalendarEventsAsync()
        {
            return _context.CalendarEvents;
        }

        public async Task<CalendarEvent> GetCalendarEventAsync(int id)
        {
            return await _context.FindAsync<CalendarEvent>(id);
        }
    }
}
