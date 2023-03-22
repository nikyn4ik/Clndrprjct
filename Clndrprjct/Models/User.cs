using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

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

        public List<CalendarEvent> CalendarEvents { get; set; } = new();

        public List<Reminder> Reminders { get; set; } = new();
    }
}
