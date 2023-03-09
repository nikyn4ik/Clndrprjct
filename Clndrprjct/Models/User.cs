using Clndrprjct.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public virtual ICollection<CalendarEvent> CalendarEvents { get; set; }

        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}
