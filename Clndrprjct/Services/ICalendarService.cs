using Clndrprjct.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clndrprjct.Services.Interfaces
//namespace Clndrprjct.Services
{
    public interface ICalendarService
    {
        Task<IEnumerable<CalendarEvent>> GetCalendarEventsAsync();
        Task<CalendarEvent> GetCalendarEventAsync(int id);
        Task AddCalendarEventAsync(CalendarEvent calendarEvent);
        Task UpdateCalendarEventAsync(CalendarEvent calendarEvent);
        Task DeleteCalendarEventAsync(int id);
    }
}
