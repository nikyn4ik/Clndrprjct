using Clndrprjct.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clndrprjct.Data
{
    public interface ICalendarEventRepository
    {
        Task<CalendarEvent> GetCalendarEventByIdAsync(int id);
        Task<IEnumerable<CalendarEvent>> GetCalendarEventsByUserIdAsync(int userId);
        Task AddCalendarEventAsync(CalendarEvent calendarEvent);
        Task UpdateCalendarEventAsync(CalendarEvent calendarEvent);
        Task DeleteCalendarEventAsync(CalendarEvent calendarEvent);
    }
}
