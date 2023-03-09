using Clndrprjct.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int CalendarEventId { get; set; }

        public virtual CalendarEvent CalendarEvent { get; set; }
    }
}
