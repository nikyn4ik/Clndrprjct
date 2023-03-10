using Clndrprjct.Models;
using System.Collections.Generic;

namespace Clndrprjct.Data.Interfaces
{
    public interface ICalendarEventService
    {
        List<CalendarEvent> GetAllEvents();
        CalendarEvent GetEventById(int id);
        void AddEvent(CalendarEvent calendarEvent);
        void UpdateEvent(CalendarEvent calendarEvent);
        void DeleteEvent(int id);
    }
}
