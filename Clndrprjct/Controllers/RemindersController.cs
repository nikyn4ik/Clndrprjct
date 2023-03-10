using Clndrprjct.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clndrprjct.Data;

namespace Clndrprjct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemindersController : ControllerBase
    {
        private readonly CalendarContext _context;

        public RemindersController(CalendarContext context)
        {
            _context = context;
        }

        // GET: api/Reminders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reminder>>> GetReminders()
        {
            return await _context.Reminders.ToListAsync();
        }

        // GET: api/Reminders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reminder>> GetReminder(int id)
        {
            var reminder = await _context.Reminders.FindAsync(id);

            if (reminder == null)
            {
                return NotFound();
            }

            return reminder;
        }

        // POST: api/Reminders
        [HttpPost]
        public async Task<ActionResult<Reminder>> PostReminder(Reminder reminder)
        {
            _context.Reminders.Add(reminder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReminder), new { id = reminder.Id }, reminder);
        }

        // PUT: api/Reminders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReminder(int id, Reminder reminder)
        {
            if (id != reminder.Id)
            {
                return BadRequest();
            }

            _context.Entry(reminder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Reminders.Any(e => e.Id == id))
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

        // DELETE: api/Reminders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReminder(int id)
        {
            var reminder = await _context.Reminders.FindAsync(id);
            if (reminder == null)
            {
                return NotFound();
            }

            _context.Reminders.Remove(reminder);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
