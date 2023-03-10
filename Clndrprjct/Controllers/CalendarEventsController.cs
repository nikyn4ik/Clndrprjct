using Clndrprjct.Data;
using Clndrprjct.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clndrprjct.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clndrprjct.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarEventsController : ControllerBase
    {
        private readonly ICalendarEventRepository _calendarEventRepository;
        private readonly IUserRepository _userRepository;

        public CalendarEventsController(ICalendarEventRepository calendarEventRepository, IUserRepository userRepository)
        {
            _calendarEventRepository = calendarEventRepository;
            _userRepository = userRepository;
        }

        // GET: api/CalendarEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetCalendarEvents()
        {
            return await _calendarEventRepository.GetCalendarEventsAsync();
        }

        // GET: api/CalendarEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEvent>> GetCalendarEvent(int id)
        {
            var calendarEvent = await _calendarEventRepository.GetCalendarEventAsync(id);

            if (calendarEvent == null)
            {
                return NotFound();
            }

            return calendarEvent;
        }

        // POST: api/CalendarEvents
        [HttpPost]
        public async Task<ActionResult<CalendarEvent>> PostCalendarEvent(CalendarEvent calendarEvent)
        {
            if (calendarEvent.UserId != null && !_userRepository.UserExists(calendarEvent.UserId.Value))
            {
                return BadRequest("User does not exist.");
            }

            await _calendarEventRepository.AddCalendarEventAsync(calendarEvent);

            return CreatedAtAction(nameof(GetCalendarEvent), new { id = calendarEvent.Id }, calendarEvent);
        }

        // PUT: api/CalendarEvents/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarEvent(int id, CalendarEvent calendarEvent)
        {
            if (id != calendarEvent.Id)
            {
                return BadRequest();
            }

            if (calendarEvent.UserId.HasValue && !_userRepository.UserExists(calendarEvent.UserId.Value))
            {
                return BadRequest("User does not exist.");
            }

            try
            {
                await _calendarEventRepository.UpdateCalendarEventAsync(calendarEvent);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_calendarEventRepository.CalendarEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/CalendarEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalendarEvent(int id)
        {
            var calendarEvent = await _calendarEventRepository.GetCalendarEventAsync(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            await _calendarEventRepository.DeleteCalendarEventAsync(calendarEvent);

            return NoContent();
        }
    }
}
