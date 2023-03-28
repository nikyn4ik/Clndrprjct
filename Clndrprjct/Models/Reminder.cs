using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class Reminder
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        [Required]
        public Guid UserId { get; set; }

    }
}
